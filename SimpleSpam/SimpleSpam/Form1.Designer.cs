namespace SimpleSpam
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new FirefoxButton();
            this.button1 = new FirefoxButton();
            this.firefoxCheckBox1 = new FirefoxCheckBox();
            this.textBox3 = new FirefoxTextbox();
            this.firefoxH22 = new FirefoxH2();
            this.firefoxH21 = new FirefoxH2();
            this.textBox2 = new FirefoxNumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firefoxH11 = new FirefoxH1();
            this.firefoxH23 = new FirefoxH2();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.EnabledCalc = true;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.button2.Location = new System.Drawing.Point(217, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Stop";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.EnabledCalc = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.button1.Location = new System.Drawing.Point(56, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // firefoxCheckBox1
            // 
            this.firefoxCheckBox1.Bold = false;
            this.firefoxCheckBox1.Checked = false;
            this.firefoxCheckBox1.EnabledCalc = true;
            this.firefoxCheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firefoxCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.firefoxCheckBox1.Location = new System.Drawing.Point(135, 228);
            this.firefoxCheckBox1.Name = "firefoxCheckBox1";
            this.firefoxCheckBox1.Size = new System.Drawing.Size(108, 27);
            this.firefoxCheckBox1.TabIndex = 12;
            this.firefoxCheckBox1.Text = "Custom(MS)";
            this.firefoxCheckBox1.CheckedChanged += new FirefoxCheckBox.CheckedChangedEventHandler(this.firefoxCheckBox1_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.EnabledCalc = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.textBox3.Location = new System.Drawing.Point(249, 226);
            this.textBox3.MaxLength = 32767;
            this.textBox3.MultiLine = false;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = false;
            this.textBox3.Size = new System.Drawing.Size(95, 29);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "100";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox3.UseSystemPasswordChar = false;
            // 
            // firefoxH22
            // 
            this.firefoxH22.AutoSize = true;
            this.firefoxH22.BackColor = System.Drawing.Color.White;
            this.firefoxH22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.firefoxH22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.firefoxH22.Location = new System.Drawing.Point(23, 200);
            this.firefoxH22.Name = "firefoxH22";
            this.firefoxH22.Size = new System.Drawing.Size(57, 19);
            this.firefoxH22.TabIndex = 8;
            this.firefoxH22.Text = "Power:";
            // 
            // firefoxH21
            // 
            this.firefoxH21.AutoSize = true;
            this.firefoxH21.BackColor = System.Drawing.Color.White;
            this.firefoxH21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.firefoxH21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.firefoxH21.Location = new System.Drawing.Point(23, 50);
            this.firefoxH21.Name = "firefoxH21";
            this.firefoxH21.Size = new System.Drawing.Size(71, 19);
            this.firefoxH21.TabIndex = 7;
            this.firefoxH21.Text = "Message:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.EnabledCalc = true;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.textBox2.Location = new System.Drawing.Point(27, 225);
            this.textBox2.Maximum = 3;
            this.textBox2.Minimum = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 30);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "firefoxNumericUpDown1";
            this.textBox2.Value = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 124);
            this.textBox1.TabIndex = 15;
            // 
            // firefoxH11
            // 
            this.firefoxH11.AutoSize = true;
            this.firefoxH11.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.firefoxH11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.firefoxH11.Location = new System.Drawing.Point(99, 9);
            this.firefoxH11.Name = "firefoxH11";
            this.firefoxH11.Size = new System.Drawing.Size(169, 37);
            this.firefoxH11.TabIndex = 16;
            this.firefoxH11.Text = "SimpleSpam";
            // 
            // firefoxH23
            // 
            this.firefoxH23.AutoSize = true;
            this.firefoxH23.BackColor = System.Drawing.Color.White;
            this.firefoxH23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.firefoxH23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.firefoxH23.Location = new System.Drawing.Point(80, 273);
            this.firefoxH23.Name = "firefoxH23";
            this.firefoxH23.Size = new System.Drawing.Size(201, 19);
            this.firefoxH23.TabIndex = 17;
            this.firefoxH23.Text = "Press \'Q\' to stop spamming;)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 345);
            this.Controls.Add(this.firefoxH23);
            this.Controls.Add(this.firefoxH11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.firefoxCheckBox1);
            this.Controls.Add(this.firefoxH21);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.firefoxH22);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SimpleSpam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private FirefoxCheckBox firefoxCheckBox1;
        private FirefoxTextbox textBox3;
        private FirefoxH2 firefoxH22;
        private FirefoxH2 firefoxH21;
        private FirefoxNumericUpDown textBox2;
        private FirefoxButton button2;
        private FirefoxButton button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private FirefoxH1 firefoxH11;
        private FirefoxH2 firefoxH23;
    }
}

