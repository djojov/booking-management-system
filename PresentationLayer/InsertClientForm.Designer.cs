using System.ComponentModel;

namespace PresentationLayer
{
    partial class InsertClientForm
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
            this.button_InsertClient = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_InsertClient
            // 
            this.button_InsertClient.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.button_InsertClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_InsertClient.ForeColor = System.Drawing.SystemColors.Control;
            this.button_InsertClient.Location = new System.Drawing.Point(49, 262);
            this.button_InsertClient.Margin = new System.Windows.Forms.Padding(4);
            this.button_InsertClient.Name = "button_InsertClient";
            this.button_InsertClient.Size = new System.Drawing.Size(160, 58);
            this.button_InsertClient.TabIndex = 53;
            this.button_InsertClient.Text = "Insert";
            this.button_InsertClient.UseVisualStyleBackColor = false;
            this.button_InsertClient.Click += new System.EventHandler(this.button_InsertClient_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Email.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_Email.Location = new System.Drawing.Point(271, 171);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(205, 26);
            this.textBox_Email.TabIndex = 52;
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(271, 121);
            this.textBox_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(205, 26);
            this.textBox_PhoneNumber.TabIndex = 51;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_LastName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_LastName.Location = new System.Drawing.Point(269, 74);
            this.textBox_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(205, 26);
            this.textBox_LastName.TabIndex = 50;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_FirstName.Location = new System.Drawing.Point(269, 34);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(205, 26);
            this.textBox_FirstName.TabIndex = 49;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Email.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_Email.Location = new System.Drawing.Point(127, 175);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(69, 20);
            this.label_Email.TabIndex = 48;
            this.label_Email.Text = "E-mail:";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_PhoneNumber.Location = new System.Drawing.Point(49, 128);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(138, 20);
            this.label_PhoneNumber.TabIndex = 47;
            this.label_PhoneNumber.Text = "Phone Number:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_LastName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_LastName.Location = new System.Drawing.Point(87, 81);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(106, 20);
            this.label_LastName.TabIndex = 46;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_FirstName.Location = new System.Drawing.Point(87, 34);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(108, 20);
            this.label_FirstName.TabIndex = 45;
            this.label_FirstName.Text = "First Name:";
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (162)))), ((int) (((byte) (76)))));
            this.button_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Close.Location = new System.Drawing.Point(352, 262);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(124, 58);
            this.button_Close.TabIndex = 44;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // InsertClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.ClientSize = new System.Drawing.Size(527, 362);
            this.Controls.Add(this.button_InsertClient);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InsertClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Client";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_InsertClient;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Button button_Close;

        #endregion
    }
}