using System.ComponentModel;

namespace PresentationLayer
{
    partial class DashboardForm
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
            this.button_LogOut = new System.Windows.Forms.Button();
            this.button_ClientManagement = new System.Windows.Forms.Button();
            this.button_RoomManagement = new System.Windows.Forms.Button();
            this.button_ReservationManagement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NumberOfAccommodations = new System.Windows.Forms.TextBox();
            this.textBox_NumberOfClients = new System.Windows.Forms.TextBox();
            this.textBox_FreeAccommodations = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_LogOut
            // 
            this.button_LogOut.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            this.button_LogOut.Location = new System.Drawing.Point(4, 382);
            this.button_LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(235, 68);
            this.button_LogOut.TabIndex = 0;
            this.button_LogOut.Text = "Logout";
            this.button_LogOut.UseVisualStyleBackColor = false;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_ClientManagement
            // 
            this.button_ClientManagement.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.button_ClientManagement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_ClientManagement.Location = new System.Drawing.Point(4, 18);
            this.button_ClientManagement.Margin = new System.Windows.Forms.Padding(4);
            this.button_ClientManagement.Name = "button_ClientManagement";
            this.button_ClientManagement.Size = new System.Drawing.Size(235, 68);
            this.button_ClientManagement.TabIndex = 1;
            this.button_ClientManagement.Text = "Client Management";
            this.button_ClientManagement.UseVisualStyleBackColor = false;
            this.button_ClientManagement.Click += new System.EventHandler(this.button_ClientManagement_Click);
            // 
            // button_RoomManagement
            // 
            this.button_RoomManagement.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.button_RoomManagement.Location = new System.Drawing.Point(4, 115);
            this.button_RoomManagement.Margin = new System.Windows.Forms.Padding(4);
            this.button_RoomManagement.Name = "button_RoomManagement";
            this.button_RoomManagement.Size = new System.Drawing.Size(235, 68);
            this.button_RoomManagement.TabIndex = 2;
            this.button_RoomManagement.Text = "Accommodation Management";
            this.button_RoomManagement.UseVisualStyleBackColor = false;
            this.button_RoomManagement.Click += new System.EventHandler(this.button_RoomManagement_Click);
            // 
            // button_ReservationManagement
            // 
            this.button_ReservationManagement.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.button_ReservationManagement.Location = new System.Drawing.Point(4, 210);
            this.button_ReservationManagement.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReservationManagement.Name = "button_ReservationManagement";
            this.button_ReservationManagement.Size = new System.Drawing.Size(235, 68);
            this.button_ReservationManagement.TabIndex = 3;
            this.button_ReservationManagement.Text = "Reservation Management";
            this.button_ReservationManagement.UseVisualStyleBackColor = false;
            this.button_ReservationManagement.Click += new System.EventHandler(this.button_ReservationManagement_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.panel1.Controls.Add(this.button_ClientManagement);
            this.panel1.Controls.Add(this.button_RoomManagement);
            this.panel1.Controls.Add(this.button_LogOut);
            this.panel1.Controls.Add(this.button_ReservationManagement);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 673);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 79);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Booking Management System - Dashboard";
            // 
            // textBox_NumberOfAccommodations
            // 
            this.textBox_NumberOfAccommodations.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (162)))), ((int) (((byte) (76)))));
            this.textBox_NumberOfAccommodations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NumberOfAccommodations.Enabled = false;
            this.textBox_NumberOfAccommodations.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_NumberOfAccommodations.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.textBox_NumberOfAccommodations.Location = new System.Drawing.Point(180, 108);
            this.textBox_NumberOfAccommodations.Name = "textBox_NumberOfAccommodations";
            this.textBox_NumberOfAccommodations.Size = new System.Drawing.Size(60, 44);
            this.textBox_NumberOfAccommodations.TabIndex = 6;
            // 
            // textBox_NumberOfClients
            // 
            this.textBox_NumberOfClients.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (162)))), ((int) (((byte) (76)))));
            this.textBox_NumberOfClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NumberOfClients.Enabled = false;
            this.textBox_NumberOfClients.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_NumberOfClients.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.textBox_NumberOfClients.Location = new System.Drawing.Point(129, 108);
            this.textBox_NumberOfClients.Name = "textBox_NumberOfClients";
            this.textBox_NumberOfClients.Size = new System.Drawing.Size(60, 44);
            this.textBox_NumberOfClients.TabIndex = 7;
            this.textBox_NumberOfClients.TextChanged += new System.EventHandler(this.textBox_NumberOfClients_TextChanged);
            // 
            // textBox_FreeAccommodations
            // 
            this.textBox_FreeAccommodations.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (162)))), ((int) (((byte) (76)))));
            this.textBox_FreeAccommodations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_FreeAccommodations.Enabled = false;
            this.textBox_FreeAccommodations.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_FreeAccommodations.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.textBox_FreeAccommodations.Location = new System.Drawing.Point(209, 108);
            this.textBox_FreeAccommodations.Name = "textBox_FreeAccommodations";
            this.textBox_FreeAccommodations.Size = new System.Drawing.Size(60, 44);
            this.textBox_FreeAccommodations.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (162)))), ((int) (((byte) (76)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox_FreeAccommodations);
            this.panel3.Location = new System.Drawing.Point(785, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 165);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.label4.Location = new System.Drawing.Point(15, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 93);
            this.label4.TabIndex = 14;
            this.label4.Text = "Free accommodations";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (162)))), ((int) (((byte) (76)))));
            this.panel4.Controls.Add(this.textBox_NumberOfClients);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(292, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 165);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 80);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of clients";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (162)))), ((int) (((byte) (76)))));
            this.panel5.Controls.Add(this.textBox_NumberOfAccommodations);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(515, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 165);
            this.panel5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 127);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of accomodations";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.ClientSize = new System.Drawing.Size(1094, 494);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.TextBox textBox_FreeAccommodations;

        private System.Windows.Forms.TextBox textBox_NumberOfClients;

        private System.Windows.Forms.TextBox textBox_NumberOfAccommodations;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button button_ReservationManagement;

        private System.Windows.Forms.Button button_RoomManagement;

        private System.Windows.Forms.Button button_ClientManagement;

        private System.Windows.Forms.Button button_LogOut;

        #endregion
    }
}