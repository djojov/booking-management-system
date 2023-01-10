using System.ComponentModel;

namespace PresentationLayer
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.button_Login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(171, 443);
            this.button_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(141, 59);
            this.button_Login.TabIndex = 11;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_Password.Location = new System.Drawing.Point(188, 379);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(221, 34);
            this.textBox_Password.TabIndex = 10;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Username.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_Username.Location = new System.Drawing.Point(188, 319);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(221, 34);
            this.textBox_Username.TabIndex = 9;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_Password.Location = new System.Drawing.Point(59, 385);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(102, 25);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password:";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Username.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_Username.Location = new System.Drawing.Point(53, 325);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(106, 25);
            this.label_Username.TabIndex = 7;
            this.label_Username.Text = "Username:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label1.Location = new System.Drawing.Point(93, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 77);
            this.label1.TabIndex = 12;
            this.label1.Text = "Booking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Close.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.button_Close.Location = new System.Drawing.Point(463, 11);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(42, 41);
            this.button_Close.TabIndex = 14;
            this.button_Close.Text = "✕";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.ClientSize = new System.Drawing.Size(517, 527);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_Close;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Username;

        #endregion
    }
}