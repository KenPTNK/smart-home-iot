namespace Smart_Home_IOT_Final_Version
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connectivity_groupBox = new System.Windows.Forms.GroupBox();
            this.Connectivity_Status_Label = new System.Windows.Forms.Label();
            this.Connectivity_label = new System.Windows.Forms.Label();
            this.Connectivity_Connect_btn = new System.Windows.Forms.Button();
            this.Connectivity_Read_btn = new System.Windows.Forms.Button();
            this.Sensors_groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Connectivity_groupBox.SuspendLayout();
            this.Sensors_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "IOT Application in Control and Monitoring Smart Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(797, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "IOT Application in Control and Monitoring Smart Home";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Connectivity_groupBox
            // 
            this.Connectivity_groupBox.Controls.Add(this.Connectivity_Read_btn);
            this.Connectivity_groupBox.Controls.Add(this.Connectivity_Connect_btn);
            this.Connectivity_groupBox.Controls.Add(this.Connectivity_label);
            this.Connectivity_groupBox.Controls.Add(this.Connectivity_Status_Label);
            this.Connectivity_groupBox.Location = new System.Drawing.Point(52, 117);
            this.Connectivity_groupBox.Name = "Connectivity_groupBox";
            this.Connectivity_groupBox.Size = new System.Drawing.Size(452, 211);
            this.Connectivity_groupBox.TabIndex = 2;
            this.Connectivity_groupBox.TabStop = false;
            this.Connectivity_groupBox.Text = "Connectivity";
            this.Connectivity_groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Connectivity_Status_Label
            // 
            this.Connectivity_Status_Label.AutoSize = true;
            this.Connectivity_Status_Label.Location = new System.Drawing.Point(22, 49);
            this.Connectivity_Status_Label.Name = "Connectivity_Status_Label";
            this.Connectivity_Status_Label.Size = new System.Drawing.Size(120, 36);
            this.Connectivity_Status_Label.TabIndex = 0;
            this.Connectivity_Status_Label.Text = "Status: ";
            // 
            // Connectivity_label
            // 
            this.Connectivity_label.AutoSize = true;
            this.Connectivity_label.Location = new System.Drawing.Point(192, 49);
            this.Connectivity_label.Name = "Connectivity_label";
            this.Connectivity_label.Size = new System.Drawing.Size(196, 36);
            this.Connectivity_label.TabIndex = 1;
            this.Connectivity_label.Text = "Disconnected";
            // 
            // Connectivity_Connect_btn
            // 
            this.Connectivity_Connect_btn.Location = new System.Drawing.Point(28, 113);
            this.Connectivity_Connect_btn.Name = "Connectivity_Connect_btn";
            this.Connectivity_Connect_btn.Size = new System.Drawing.Size(162, 77);
            this.Connectivity_Connect_btn.TabIndex = 2;
            this.Connectivity_Connect_btn.Text = "Kết nối";
            this.Connectivity_Connect_btn.UseVisualStyleBackColor = true;
            // 
            // Connectivity_Read_btn
            // 
            this.Connectivity_Read_btn.Location = new System.Drawing.Point(198, 113);
            this.Connectivity_Read_btn.Name = "Connectivity_Read_btn";
            this.Connectivity_Read_btn.Size = new System.Drawing.Size(229, 77);
            this.Connectivity_Read_btn.TabIndex = 3;
            this.Connectivity_Read_btn.Text = "Đoc dữ liệu";
            this.Connectivity_Read_btn.UseVisualStyleBackColor = true;
            this.Connectivity_Read_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sensors_groupBox
            // 
            this.Sensors_groupBox.Controls.Add(this.groupBox2);
            this.Sensors_groupBox.Controls.Add(this.groupBox1);
            this.Sensors_groupBox.Location = new System.Drawing.Point(52, 334);
            this.Sensors_groupBox.Name = "Sensors_groupBox";
            this.Sensors_groupBox.Size = new System.Drawing.Size(452, 386);
            this.Sensors_groupBox.TabIndex = 8;
            this.Sensors_groupBox.TabStop = false;
            this.Sensors_groupBox.Text = "Sensor Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(28, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature (C)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(28, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Humidity (%)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 44);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(399, 44);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(541, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 603);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Devices Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Air Conditional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Connected";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 77);
            this.button1.TabIndex = 3;
            this.button1.Text = "On";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 77);
            this.button2.TabIndex = 4;
            this.button2.Text = "Off";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 77);
            this.button3.TabIndex = 9;
            this.button3.Text = "Off";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 77);
            this.button4.TabIndex = 8;
            this.button4.Text = "On";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Connected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 36);
            this.label8.TabIndex = 5;
            this.label8.Text = "Light";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Sensors_groupBox);
            this.Controls.Add(this.Connectivity_groupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Smart Home IOT - Firebase C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Connectivity_groupBox.ResumeLayout(false);
            this.Connectivity_groupBox.PerformLayout();
            this.Sensors_groupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Connectivity_groupBox;
        private System.Windows.Forms.Label Connectivity_Status_Label;
        private System.Windows.Forms.Button Connectivity_Read_btn;
        private System.Windows.Forms.Button Connectivity_Connect_btn;
        private System.Windows.Forms.Label Connectivity_label;
        private System.Windows.Forms.GroupBox Sensors_groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

