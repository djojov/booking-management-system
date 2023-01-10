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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_LogOut
            // 
            this.button_LogOut.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            this.button_LogOut.Location = new System.Drawing.Point(8, 601);
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
            this.button_ClientManagement.Location = new System.Drawing.Point(4, 175);
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
            this.button_RoomManagement.Location = new System.Drawing.Point(4, 272);
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
            this.button_ReservationManagement.Location = new System.Drawing.Point(4, 367);
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
            this.label1.Size = new System.Drawing.Size(458, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Booking Management System";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.ClientSize = new System.Drawing.Size(1133, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

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