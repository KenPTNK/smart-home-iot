using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHomeIoTFinalVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        HttpClient client = new HttpClient();

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_status_connect.Text == "Connect")
                {
                    client.Timeout = TimeSpan.FromSeconds(10);
                    HttpResponseMessage response = await client.GetAsync(firebase_url.Text);

                    if (response.IsSuccessStatusCode)
                    {
                        connect_status.Text = "Connected";
                    }
                    else
                    {
                        connect_status.Text = "Failed";
                    }
                    btn_status_connect.Text = "Disconected";
                }
            }
            catch (Exception ex)
            {
                connect_status.Text = "Pls try again";
                MessageBox.Show(ex.Message);
            }
        }

        private async Task read_data()
        {
            try
            {
                string json = await client.GetStringAsync(firebase_url.Text + ".json");
                JObject data = JObject.Parse(json);
                humidity.Text = data["Sensors"]["Humidity"].ToString();
                temp.Text = data["Sensors"]["Temperature"].ToString();

                status_aircon.Text = data["Device"]["Aircon_Status"].ToString();
                status_light.Text = data["Device"]["Light_Status"].ToString();

                if (status_aircon.Text == "Online")
                {
                    btn_aircon_on.Visible = true;
                    btn_aircon_off.Visible = true;
                }
                else
                {
                    btn_aircon_on.Visible = false;
                    btn_aircon_off.Visible = false;
                }

                if (status_light.Text == "Online")
                {
                    btn_light_on.Visible = true;
                    btn_light_off.Visible = true;
                }
                else
                {
                    btn_light_on.Visible = false;
                    btn_light_off.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button10_Click(object sender, EventArgs e)
        {
            await SendData("Device/Light", "ON");
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            await SendData("Device/Airconditional", "ON");
        }

        private void firebase_url_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_onoff_read_Click(object sender, EventArgs e)
        {
            await read_data();
            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await read_data();
        }

        private async Task SendData(string path, string value)
        {
            try
            {
                string url = firebase_url.Text + path + ".json";

                StringContent content = new StringContent("\"" + value + "\"", Encoding.UTF8, "application/json");
                await client.PutAsync(url, content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btn_light_off_Click(object sender, EventArgs e)
        {
            await SendData("Device/Light", "OFF");
        }

        private async void btn_aircon_off_Click(object sender, EventArgs e)
        {
            await SendData("Device/Airconditional", "OFF");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void connect_status_Click(object sender, EventArgs e)
        {

        }
    }
}
