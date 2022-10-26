namespace cru_robot
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label20 = new System.Windows.Forms.Label();
            this.speed_motor_R = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.speed_motor_L = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Duty2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Duty1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.writebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(401, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 62;
            this.label20.Text = "RPM";
            // 
            // speed_motor_R
            // 
            this.speed_motor_R.Location = new System.Drawing.Point(295, 58);
            this.speed_motor_R.Name = "speed_motor_R";
            this.speed_motor_R.Size = new System.Drawing.Size(100, 20);
            this.speed_motor_R.TabIndex = 61;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(241, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 60;
            this.label21.Text = "Speed";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(181, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 59;
            this.label18.Text = "RPM";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // speed_motor_L
            // 
            this.speed_motor_L.Location = new System.Drawing.Point(75, 58);
            this.speed_motor_L.Name = "speed_motor_L";
            this.speed_motor_L.Size = new System.Drawing.Size(100, 20);
            this.speed_motor_L.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Motor-R";
            // 
            // Duty2
            // 
            this.Duty2.Location = new System.Drawing.Point(295, 32);
            this.Duty2.Name = "Duty2";
            this.Duty2.Size = new System.Drawing.Size(100, 20);
            this.Duty2.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Duty Cycle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Motor-L";
            // 
            // Duty1
            // 
            this.Duty1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Duty1.Location = new System.Drawing.Point(75, 28);
            this.Duty1.Name = "Duty1";
            this.Duty1.Size = new System.Drawing.Size(100, 20);
            this.Duty1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Duty Cycle";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(206, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 82);
            this.listBox1.TabIndex = 64;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // writebutton
            // 
            this.writebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.writebutton.Image = global::cru_robot.Properties.Resources.unnamed;
            this.writebutton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.writebutton.Location = new System.Drawing.Point(17, 119);
            this.writebutton.Name = "writebutton";
            this.writebutton.Size = new System.Drawing.Size(183, 82);
            this.writebutton.TabIndex = 63;
            this.writebutton.Text = "write";
            this.writebutton.UseVisualStyleBackColor = true;
            this.writebutton.Click += new System.EventHandler(this.writebutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 213);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.writebutton);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.speed_motor_R);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.speed_motor_L);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Duty2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Duty1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Motor setup";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox speed_motor_R;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox speed_motor_L;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Duty2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Duty1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button writebutton;
        private System.Windows.Forms.ListBox listBox1;
    }
}