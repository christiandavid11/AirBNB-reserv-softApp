namespace AirBNB
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
            this.panel_Border = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_EmailContactNo = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.label_InvalidEmail = new System.Windows.Forms.Label();
            this.label_IncorrectPassword = new System.Windows.Forms.Label();
            this.label_AccountDoesntExist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Border.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Border
            // 
            this.panel_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(141)))));
            this.panel_Border.Controls.Add(this.label4);
            this.panel_Border.Controls.Add(this.button_Close);
            this.panel_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Border.Location = new System.Drawing.Point(0, 0);
            this.panel_Border.Name = "panel_Border";
            this.panel_Border.Size = new System.Drawing.Size(800, 33);
            this.panel_Border.TabIndex = 0;
            this.panel_Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Border_MouseDown);
            this.panel_Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Border_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Airbnb, OVBS";
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(739, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(61, 33);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            this.button_Close.MouseLeave += new System.EventHandler(this.button_Close_MouseLeave);
            this.button_Close.MouseHover += new System.EventHandler(this.button_Close_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 470);
            this.label1.TabIndex = 1;
            this.label1.Text = "Airbnb\r\nOnline\r\nVacation\r\nBooking\r\nSystem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // textBox_EmailContactNo
            // 
            this.textBox_EmailContactNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_EmailContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_EmailContactNo.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmailContactNo.Location = new System.Drawing.Point(527, 163);
            this.textBox_EmailContactNo.Name = "textBox_EmailContactNo";
            this.textBox_EmailContactNo.Size = new System.Drawing.Size(231, 33);
            this.textBox_EmailContactNo.TabIndex = 4;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(527, 240);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(231, 33);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Login
            // 
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(535, 344);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(112, 52);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.button_Register.FlatAppearance.BorderSize = 0;
            this.button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Register.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Location = new System.Drawing.Point(535, 411);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(112, 52);
            this.button_Register.TabIndex = 7;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // label_InvalidEmail
            // 
            this.label_InvalidEmail.AutoSize = true;
            this.label_InvalidEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.label_InvalidEmail.Location = new System.Drawing.Point(598, 199);
            this.label_InvalidEmail.Name = "label_InvalidEmail";
            this.label_InvalidEmail.Size = new System.Drawing.Size(85, 20);
            this.label_InvalidEmail.TabIndex = 8;
            this.label_InvalidEmail.Text = "Invalid Email";
            this.label_InvalidEmail.Visible = false;
            // 
            // label_IncorrectPassword
            // 
            this.label_IncorrectPassword.AutoSize = true;
            this.label_IncorrectPassword.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IncorrectPassword.ForeColor = System.Drawing.Color.Red;
            this.label_IncorrectPassword.Location = new System.Drawing.Point(576, 276);
            this.label_IncorrectPassword.Name = "label_IncorrectPassword";
            this.label_IncorrectPassword.Size = new System.Drawing.Size(128, 20);
            this.label_IncorrectPassword.TabIndex = 9;
            this.label_IncorrectPassword.Text = "Incorrect Password";
            this.label_IncorrectPassword.Visible = false;
            // 
            // label_AccountDoesntExist
            // 
            this.label_AccountDoesntExist.AutoSize = true;
            this.label_AccountDoesntExist.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountDoesntExist.ForeColor = System.Drawing.Color.Red;
            this.label_AccountDoesntExist.Location = new System.Drawing.Point(576, 199);
            this.label_AccountDoesntExist.Name = "label_AccountDoesntExist";
            this.label_AccountDoesntExist.Size = new System.Drawing.Size(145, 20);
            this.label_AccountDoesntExist.TabIndex = 10;
            this.label_AccountDoesntExist.Text = "Account Doesn\'t Exist";
            this.label_AccountDoesntExist.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 476);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_AccountDoesntExist);
            this.Controls.Add(this.label_IncorrectPassword);
            this.Controls.Add(this.label_InvalidEmail);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_EmailContactNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Border.ResumeLayout(false);
            this.panel_Border.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Border;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_EmailContactNo;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_InvalidEmail;
        private System.Windows.Forms.Label label_IncorrectPassword;
        private System.Windows.Forms.Label label_AccountDoesntExist;
        private System.Windows.Forms.Panel panel1;
    }
}

