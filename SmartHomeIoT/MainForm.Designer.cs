using System.Drawing;
using System.Windows.Forms;

namespace SmartHomeIoT
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblConnectionStatus;
        private Label lblTemperatureValue;
        private Label lblHumidityValue;
        private Label lblAirConditionerStatus;
        private Label lblLightStatus;
        private Label lblUpdatedAt;
        private TextBox txtFirebaseUrl;
        private GradientButton btnConnect;
        private GradientButton btnReadData;
        private GradientButton btnAirOn;
        private GradientButton btnAirOff;
        private GradientButton btnLightOn;
        private GradientButton btnLightOff;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            Color blue = Color.FromArgb(18, 81, 171);
            Color green = Color.FromArgb(34, 150, 53);
            Color red = Color.FromArgb(210, 38, 38);
            Color border = Color.FromArgb(224, 224, 224);

            this.SuspendLayout();

            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.FromArgb(250, 250, 250);
            this.ClientSize = new Size(1280, 800);
            this.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Smart Home IoT - Firebase & C#";

            Label title = CreateLabel(
                "ỨNG DỤNG IoT TRONG ĐIỀU KHIỂN VÀ GIÁM SÁT NHÀ THÔNG MINH",
                new Point(0, 28),
                new Size(1280, 45),
                new Font("Segoe UI", 24F, FontStyle.Bold),
                blue,
                ContentAlignment.MiddleCenter);

            Label subtitle = CreateLabel(
                "SỬ DỤNG FIREBASE VÀ C#",
                new Point(0, 76),
                new Size(1280, 38),
                new Font("Segoe UI", 20F, FontStyle.Bold),
                green,
                ContentAlignment.MiddleCenter);

            RoundedPanel pnlConnection = CreatePanel(new Point(25, 130), new Size(450, 170), border);
            pnlConnection.Controls.Add(CreateSectionTitle("KẾT NỐI", new Point(23, 18), blue));
            pnlConnection.Controls.Add(CreateLabel("Trạng thái:", new Point(23, 66), new Size(115, 30), new Font("Segoe UI", 14F), Color.Black, ContentAlignment.MiddleLeft));

            lblConnectionStatus = CreateLabel("Đã kết nối Firebase", new Point(142, 66), new Size(240, 30), new Font("Segoe UI", 14F, FontStyle.Bold), green, ContentAlignment.MiddleLeft);
            pnlConnection.Controls.Add(lblConnectionStatus);

            btnConnect = CreateActionButton("KẾT NỐI", SmartIconKind.Plug, green, new Point(23, 110), new Size(175, 50));
            btnReadData = CreateActionButton("ĐỌC DỮ LIỆU", SmartIconKind.Refresh, Color.FromArgb(17, 105, 209), new Point(220, 110), new Size(205, 50));
            pnlConnection.Controls.Add(btnConnect);
            pnlConnection.Controls.Add(btnReadData);

            RoundedPanel pnlSensors = CreatePanel(new Point(25, 320), new Size(450, 450), border);
            pnlSensors.Controls.Add(CreateSectionTitle("THÔNG TIN CẢM BIẾN", new Point(23, 18), blue));

            RoundedPanel tempCard = CreatePanel(new Point(23, 75), new Size(404, 125), border);
            tempCard.Controls.Add(CreateIcon(SmartIconKind.Thermometer, new Point(30, 24), new Size(75, 75), Color.FromArgb(29, 132, 219)));
            tempCard.Controls.Add(CreateLabel("Nhiệt độ (°C)", new Point(145, 22), new Size(190, 30), new Font("Segoe UI", 14F), Color.Black, ContentAlignment.MiddleLeft));
            lblTemperatureValue = CreateValueBox("28.5", new Point(145, 62), new Size(230, 54), blue);
            tempCard.Controls.Add(lblTemperatureValue);

            RoundedPanel humidityCard = CreatePanel(new Point(23, 225), new Size(404, 125), border);
            humidityCard.Controls.Add(CreateIcon(SmartIconKind.WaterDrop, new Point(28, 24), new Size(78, 78), Color.FromArgb(29, 132, 219)));
            humidityCard.Controls.Add(CreateLabel("Độ ẩm (%)", new Point(145, 22), new Size(190, 30), new Font("Segoe UI", 14F), Color.Black, ContentAlignment.MiddleLeft));
            lblHumidityValue = CreateValueBox("90.3", new Point(145, 62), new Size(230, 54), blue);
            humidityCard.Controls.Add(lblHumidityValue);

            Panel sensorDivider = new Panel();
            sensorDivider.BackColor = Color.FromArgb(226, 226, 226);
            sensorDivider.Location = new Point(0, 375);
            sensorDivider.Size = new Size(450, 1);

            pnlSensors.Controls.Add(tempCard);
            pnlSensors.Controls.Add(humidityCard);
            pnlSensors.Controls.Add(sensorDivider);
            pnlSensors.Controls.Add(CreateIcon(SmartIconKind.Clock, new Point(20, 405), new Size(32, 32), Color.Black));
            lblUpdatedAt = CreateLabel("Cập nhật lúc: 11:23:45", new Point(58, 398), new Size(270, 45), new Font("Segoe UI", 13F), Color.Black, ContentAlignment.MiddleLeft);
            pnlSensors.Controls.Add(lblUpdatedAt);

            RoundedPanel pnlControls = CreatePanel(new Point(500, 130), new Size(755, 520), border);
            pnlControls.Controls.Add(CreateSectionTitle("ĐIỀU KHIỂN THIẾT BỊ", new Point(25, 18), blue));

            RoundedPanel airCard = CreatePanel(new Point(25, 75), new Size(705, 195), border);
            airCard.Controls.Add(CreateIcon(SmartIconKind.AirConditioner, new Point(25, 26), new Size(240, 120), Color.Empty));
            airCard.Controls.Add(CreateLabel("Điều hòa", new Point(285, 48), new Size(145, 35), new Font("Segoe UI", 15F, FontStyle.Bold), Color.Black, ContentAlignment.MiddleLeft));
            airCard.Controls.Add(CreateLabel("Trạng thái:", new Point(430, 48), new Size(115, 35), new Font("Segoe UI", 13F), Color.Black, ContentAlignment.MiddleLeft));
            lblAirConditionerStatus = CreateLabel("ON", new Point(545, 48), new Size(70, 35), new Font("Segoe UI", 14F, FontStyle.Bold), green, ContentAlignment.MiddleLeft);
            airCard.Controls.Add(lblAirConditionerStatus);
            btnAirOn = CreateActionButton("BẬT", SmartIconKind.None, green, new Point(430, 108), new Size(145, 52));
            btnAirOff = CreateActionButton("TẮT", SmartIconKind.None, red, new Point(600, 108), new Size(145, 52));
            airCard.Controls.Add(btnAirOn);
            airCard.Controls.Add(btnAirOff);

            RoundedPanel lightCard = CreatePanel(new Point(25, 295), new Size(705, 195), border);
            lightCard.Controls.Add(CreateIcon(SmartIconKind.LightBulb, new Point(55, 18), new Size(175, 145), Color.Empty));
            lightCard.Controls.Add(CreateLabel("Ánh sáng", new Point(285, 48), new Size(145, 35), new Font("Segoe UI", 15F, FontStyle.Bold), Color.Black, ContentAlignment.MiddleLeft));
            lightCard.Controls.Add(CreateLabel("Trạng thái:", new Point(430, 48), new Size(115, 35), new Font("Segoe UI", 13F), Color.Black, ContentAlignment.MiddleLeft));
            lblLightStatus = CreateLabel("ON", new Point(545, 48), new Size(70, 35), new Font("Segoe UI", 14F, FontStyle.Bold), green, ContentAlignment.MiddleLeft);
            lightCard.Controls.Add(lblLightStatus);
            btnLightOn = CreateActionButton("BẬT", SmartIconKind.None, green, new Point(430, 108), new Size(145, 52));
            btnLightOff = CreateActionButton("TẮT", SmartIconKind.None, red, new Point(600, 108), new Size(145, 52));
            lightCard.Controls.Add(btnLightOn);
            lightCard.Controls.Add(btnLightOff);

            pnlControls.Controls.Add(airCard);
            pnlControls.Controls.Add(lightCard);

            RoundedPanel pnlFirebase = CreatePanel(new Point(500, 675), new Size(755, 95), border);
            pnlFirebase.Controls.Add(CreateSectionTitle("DỮ LIỆU FIREBASE (Realtime Database)", new Point(25, 15), blue));
            txtFirebaseUrl = new TextBox();
            txtFirebaseUrl.BorderStyle = BorderStyle.FixedSingle;
            txtFirebaseUrl.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            txtFirebaseUrl.Location = new Point(25, 55);
            txtFirebaseUrl.Name = "txtFirebaseUrl";
            txtFirebaseUrl.ReadOnly = true;
            txtFirebaseUrl.Size = new Size(595, 32);
            txtFirebaseUrl.Text = "https://iot-system-5497a-default-rtdb.asia-southeast1.firebasedatabase.app/";
            pnlFirebase.Controls.Add(txtFirebaseUrl);
            pnlFirebase.Controls.Add(CreateIcon(SmartIconKind.Firebase, new Point(652, 18), new Size(75, 65), Color.Empty));

            this.Controls.Add(title);
            this.Controls.Add(subtitle);
            this.Controls.Add(pnlConnection);
            this.Controls.Add(pnlSensors);
            this.Controls.Add(pnlControls);
            this.Controls.Add(pnlFirebase);

            this.ResumeLayout(false);
        }

        #endregion

        private RoundedPanel CreatePanel(Point location, Size size, Color borderColor)
        {
            RoundedPanel panel = new RoundedPanel();
            panel.BorderColor = borderColor;
            panel.BorderRadius = 8;
            panel.Location = location;
            panel.Size = size;
            panel.BackColor = Color.White;
            return panel;
        }

        private Label CreateSectionTitle(string text, Point location, Color color)
        {
            return CreateLabel(text, location, new Size(390, 35), new Font("Segoe UI", 14F, FontStyle.Bold), color, ContentAlignment.MiddleLeft);
        }

        private Label CreateLabel(string text, Point location, Size size, Font font, Color color, ContentAlignment alignment)
        {
            Label label = new Label();
            label.AutoSize = false;
            label.BackColor = Color.Transparent;
            label.Font = font;
            label.ForeColor = color;
            label.Location = location;
            label.Size = size;
            label.Text = text;
            label.TextAlign = alignment;
            return label;
        }

        private Label CreateValueBox(string text, Point location, Size size, Color color)
        {
            Label value = CreateLabel(text, location, size, new Font("Segoe UI", 21F, FontStyle.Bold), color, ContentAlignment.MiddleCenter);
            value.BackColor = Color.White;
            value.BorderStyle = BorderStyle.FixedSingle;
            return value;
        }

        private SmartIconView CreateIcon(SmartIconKind kind, Point location, Size size, Color color)
        {
            SmartIconView icon = new SmartIconView();
            icon.Kind = kind;
            icon.Location = location;
            icon.Size = size;
            icon.IconColor = color;
            return icon;
        }

        private GradientButton CreateActionButton(string text, SmartIconKind iconKind, Color mainColor, Point location, Size size)
        {
            GradientButton button = new GradientButton();
            button.BorderColor = ControlPaint.Dark(mainColor);
            button.EndColor = ControlPaint.Dark(mainColor);
            button.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.IconKind = iconKind;
            button.Location = location;
            button.Size = size;
            button.StartColor = mainColor;
            button.Text = text;
            button.UseVisualStyleBackColor = false;
            return button;
        }
    }
}
