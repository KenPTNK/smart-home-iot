using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace firebase_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cấu hình Timer: Cứ 2 giây cập nhật dữ liệu (cả sensor lẫn trạng thái thiết bị) một lần
            timer1.Interval = 2000;
        }

        // Đường dẫn gốc kết thúc bằng .json
        private readonly string firebaseurl_data = "https://iot-system-6b2f7-default-rtdb.asia-southeast1.firebasedatabase.app/.json";

        // Biến toàn cục lưu trữ trạng thái hiện tại để phục vụ tính năng bật/tắt thông minh
        private string currentAirconState = "OFF";
        private string currentLightState = "OFF";

        // NÚT KẾT NỐI VÀ CHẠY REALTIME
        private async void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(5);
                    HttpResponseMessage response = await client.GetAsync(firebaseurl_data);

                    if (response.IsSuccessStatusCode)
                    {
                        label_result.Text = "Kết nối thành công! Đang chạy realtime...";
                        label_result.ForeColor = Color.Green;

                        // Bật timer để bắt đầu tự động cập nhật dữ liệu liên tục
                        timer1.Start();
                    }
                    else
                    {
                        label_result.Text = "Kết nối thất bại";
                        label_result.ForeColor = Color.Red;
                        timer1.Stop();
                    }
                }
            }
            catch (Exception ex)
            {
                label_result.Text = "Lỗi kết nối";
                label_result.ForeColor = Color.Red;
                timer1.Stop();
                MessageBox.Show($"Chi tiết lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // HÀM ĐỌC DỮ LIỆU REALTIME (Đọc cả Sensors và Device)
        private async Task FetchDataFromFirebaseAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(5);
                    HttpResponseMessage response = await client.GetAsync(firebaseurl_data);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(json);

                        // 1. Đọc dữ liệu từ nhánh "Sensors"
                        if (data["Sensors"] != null)
                        {
                            textBox_humidity.Text = data["Sensors"]["Humidity"]?.ToString() ?? "N/A";
                            textBox_temperature.Text = data["Sensors"]["Temperature"]?.ToString() ?? "N/A";
                        }

                        // 2. Đọc trạng thái từ nhánh "Device" để cập nhật vào biến nền
                        if (data["Device"] != null)
                        {
                            currentAirconState = data["Device"]["Airconditional"]?.ToString() ?? "OFF";
                            currentLightState = data["Device"]["Light"]?.ToString() ?? "OFF";

                            // Mẹo nhỏ: Bạn có thể đổi màu nút hoặc hiển thị chữ lên nút/label để biết thiết bị đang bật hay tắt
                            button_aircon.Text = $"Aircon: {currentAirconState}";
                            button_light.Text = $"Light: {currentLightState}";
                        }

                        label_result.Text = "Kết nối thành công! Đang chạy realtime...";
                        label_result.ForeColor = Color.Green;
                    }
                    else
                    {
                        label_result.Text = "Lỗi phản hồi từ server";
                        label_result.ForeColor = Color.Orange;
                    }
                }
            }
            catch (Exception)
            {
                label_result.Text = "Mất kết nối mạng. Đang thử lại...";
                label_result.ForeColor = Color.Red;
            }
        }

        // SỰ KIỆN TIMER TICK (Tự động quét sau mỗi chu kỳ)
        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // Tạm dừng để tránh gối request khi mạng lag
            await FetchDataFromFirebaseAsync();
            timer1.Start(); // Chạy lại cho chu kỳ sau
        }

        // HÀM GỬI LỆNH ĐIỀU KHIỂN (PUT dữ liệu lên Firebase)
        private async Task UpdateDeviceStatusAsync(string deviceNodeName, string nextStatus)
        {
            // Kiểm tra xem đã bấm nút Kết nối chưa
            if (!timer1.Enabled && !label_result.Text.Contains("thành công"))
            {
                MessageBox.Show("Vui lòng ấn nút 'Kết nối' hệ thống trước khi điều khiển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(5);

                    // Đường dẫn chính xác đến node cần sửa, ví dụ: .../Device/Airconditional.json
                    string url = $"https://iot-system-6b2f7-default-rtdb.asia-southeast1.firebasedatabase.app/Device/{deviceNodeName}.json";

                    // Trong Firebase REST API, dữ liệu dạng chuỗi gửi lên bắt buộc phải bọc trong dấu ngoặc kép kép ("\"ON\"")
                    var content = new StringContent($"\"{nextStatus}\"", Encoding.UTF8, "application/json");

                    // Sử dụng PutAsync để ghi đè giá trị mới
                    HttpResponseMessage response = await client.PutAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Cập nhật giao diện tức thì sau khi bấm điều khiển thành công
                        await FetchDataFromFirebaseAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Điều khiển {deviceNodeName} thất bại. Mã lỗi: {response.StatusCode}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đường truyền điều khiển: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NÚT BẤM ĐIỀU KHIỂN ĐIỀU HÒA (Airconditional)
        private async void button_aircon_Click(object sender, EventArgs e)
        {
            // Đảo trạng thái: Nếu đang ON -> chuyển thành OFF và ngược lại
            string nextState = (currentAirconState == "ON") ? "OFF" : "ON";
            await UpdateDeviceStatusAsync("Airconditional", nextState);
        }

        // NÚT BẤM ĐIỀU KHIỂN ĐÈN (Light)
        private async void button_light_Click(object sender, EventArgs e)
        {
            // Đảo trạng thái: Nếu đang ON -> chuyển thành OFF và ngược lại
            string nextState = (currentLightState == "ON") ? "OFF" : "ON";
            await UpdateDeviceStatusAsync("Light", nextState);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
    }
}