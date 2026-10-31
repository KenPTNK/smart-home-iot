namespace SmartHomeIoTFinalVersion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_onoff_read = new System.Windows.Forms.Button();
            this.btn_status_connect = new System.Windows.Forms.Button();
            this.connect_status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_light_off = new System.Windows.Forms.Button();
            this.btn_light_on = new System.Windows.Forms.Button();
            this.status_light = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_aircon_off = new System.Windows.Forms.Button();
            this.btn_aircon_on = new System.Windows.Forms.Button();
            this.status_aircon = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.firebase_url = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1335, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "IoT Application for Control and monitoring in Smart Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(899, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "By using Firebase and Visual Studio C#";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_onoff_read);
            this.groupBox1.Controls.Add(this.btn_status_connect);
            this.groupBox1.Controls.Add(this.connect_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(489, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // btn_onoff_read
            // 
            this.btn_onoff_read.Location = new System.Drawing.Point(262, 102);
            this.btn_onoff_read.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_onoff_read.Name = "btn_onoff_read";
            this.btn_onoff_read.Size = new System.Drawing.Size(220, 84);
            this.btn_onoff_read.TabIndex = 6;
            this.btn_onoff_read.Text = "Read data";
            this.btn_onoff_read.UseVisualStyleBackColor = true;
            this.btn_onoff_read.Click += new System.EventHandler(this.btn_onoff_read_Click);
            // 
            // btn_status_connect
            // 
            this.btn_status_connect.Location = new System.Drawing.Point(7, 102);
            this.btn_status_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_status_connect.Name = "btn_status_connect";
            this.btn_status_connect.Size = new System.Drawing.Size(249, 84);
            this.btn_status_connect.TabIndex = 5;
            this.btn_status_connect.Text = "Connect";
            this.btn_status_connect.UseVisualStyleBackColor = true;
            this.btn_status_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // connect_status
            // 
            this.connect_status.AutoSize = true;
            this.connect_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect_status.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_status.Location = new System.Drawing.Point(275, 50);
            this.connect_status.Name = "connect_status";
            this.connect_status.Size = new System.Drawing.Size(140, 45);
            this.connect_status.TabIndex = 4;
            this.connect_status.Text = "Offline";
            this.connect_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connect_status.Click += new System.EventHandler(this.connect_status_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.humidity);
            this.groupBox2.Controls.Add(this.temp);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(489, 576);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor informations";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 45);
            this.label8.TabIndex = 10;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 45);
            this.label7.TabIndex = 9;
            this.label7.Text = "°C";
            // 
            // humidity
            // 
            this.humidity.Location = new System.Drawing.Point(262, 408);
            this.humidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(108, 53);
            this.humidity.TabIndex = 8;
            this.humidity.Text = "99.5";
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(262, 138);
            this.temp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(100, 53);
            this.temp.TabIndex = 7;
            this.temp.Text = "28.5";
            this.temp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SmartHomeIoTFinalVersion.Properties.Resources.humidity;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(7, 311);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 258);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SmartHomeIoTFinalVersion.Properties.Resources.temperature;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(7, 55);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 249);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Humidity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 45);
            this.label6.TabIndex = 3;
            this.label6.Text = "Temperature";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btn_light_off);
            this.groupBox3.Controls.Add(this.btn_light_on);
            this.groupBox3.Controls.Add(this.status_light);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.btn_aircon_off);
            this.groupBox3.Controls.Add(this.btn_aircon_on);
            this.groupBox3.Controls.Add(this.status_aircon);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(510, 142);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(897, 598);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control panel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(501, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 45);
            this.label12.TabIndex = 14;
            this.label12.Text = "Light";
            // 
            // btn_light_off
            // 
            this.btn_light_off.Location = new System.Drawing.Point(575, 499);
            this.btn_light_off.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_light_off.Name = "btn_light_off";
            this.btn_light_off.Size = new System.Drawing.Size(315, 85);
            this.btn_light_off.TabIndex = 13;
            this.btn_light_off.Text = "OFF";
            this.btn_light_off.UseVisualStyleBackColor = true;
            this.btn_light_off.Click += new System.EventHandler(this.btn_light_off_Click);
            // 
            // btn_light_on
            // 
            this.btn_light_on.Location = new System.Drawing.Point(226, 499);
            this.btn_light_on.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_light_on.Name = "btn_light_on";
            this.btn_light_on.Size = new System.Drawing.Size(315, 85);
            this.btn_light_on.TabIndex = 12;
            this.btn_light_on.Text = "ON";
            this.btn_light_on.UseVisualStyleBackColor = true;
            this.btn_light_on.Click += new System.EventHandler(this.button10_Click);
            // 
            // status_light
            // 
            this.status_light.AutoSize = true;
            this.status_light.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_light.Location = new System.Drawing.Point(567, 410);
            this.status_light.Name = "status_light";
            this.status_light.Size = new System.Drawing.Size(284, 45);
            this.status_light.TabIndex = 11;
            this.status_light.Text = "Online/Offline?";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(226, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 45);
            this.label14.TabIndex = 10;
            this.label14.Text = "Status : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(407, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 45);
            this.label11.TabIndex = 9;
            this.label11.Text = "AirConditional";
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::SmartHomeIoTFinalVersion.Properties.Resources.Light;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(7, 326);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(213, 258);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::SmartHomeIoTFinalVersion.Properties.Resources.Airconditional;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(7, 55);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(213, 258);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_aircon_off
            // 
            this.btn_aircon_off.Location = new System.Drawing.Point(575, 228);
            this.btn_aircon_off.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_aircon_off.Name = "btn_aircon_off";
            this.btn_aircon_off.Size = new System.Drawing.Size(315, 85);
            this.btn_aircon_off.TabIndex = 6;
            this.btn_aircon_off.Text = "OFF";
            this.btn_aircon_off.UseVisualStyleBackColor = true;
            this.btn_aircon_off.Click += new System.EventHandler(this.btn_aircon_off_Click);
            // 
            // btn_aircon_on
            // 
            this.btn_aircon_on.Location = new System.Drawing.Point(226, 228);
            this.btn_aircon_on.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_aircon_on.Name = "btn_aircon_on";
            this.btn_aircon_on.Size = new System.Drawing.Size(315, 85);
            this.btn_aircon_on.TabIndex = 5;
            this.btn_aircon_on.Text = "ON";
            this.btn_aircon_on.UseVisualStyleBackColor = true;
            this.btn_aircon_on.Click += new System.EventHandler(this.button6_Click);
            // 
            // status_aircon
            // 
            this.status_aircon.AutoSize = true;
            this.status_aircon.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_aircon.Location = new System.Drawing.Point(567, 139);
            this.status_aircon.Name = "status_aircon";
            this.status_aircon.Size = new System.Drawing.Size(284, 45);
            this.status_aircon.TabIndex = 4;
            this.status_aircon.Text = "Online/Offline?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(226, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 45);
            this.label10.TabIndex = 3;
            this.label10.Text = "Status : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.firebase_url);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(510, 748);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(897, 179);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Firebase URL";
            // 
            // firebase_url
            // 
            this.firebase_url.Location = new System.Drawing.Point(7, 84);
            this.firebase_url.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firebase_url.Name = "firebase_url";
            this.firebase_url.Size = new System.Drawing.Size(883, 53);
            this.firebase_url.TabIndex = 9;
            this.firebase_url.Text = "https://iot-system-6b2f7-default-rtdb.asia-southeast1.firebasedatabase.app/";
            this.firebase_url.TextChanged += new System.EventHandler(this.firebase_url_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 941);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Smart Home IoT - Firebase & C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_onoff_read;
        private System.Windows.Forms.Button btn_status_connect;
        private System.Windows.Forms.Label connect_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox humidity;
        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_aircon_off;
        private System.Windows.Forms.Button btn_aircon_on;
        private System.Windows.Forms.Label status_aircon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_light_off;
        private System.Windows.Forms.Button btn_light_on;
        private System.Windows.Forms.Label status_light;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox firebase_url;
        private System.Windows.Forms.Timer timer1;
    }
}

