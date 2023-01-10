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
            this.SuspendLayout();
            // 
            // button_LogOut
            // 
            this.button_LogOut.Location = new System.Drawing.Point(912, 497);
            this.button_LogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(100, 28);
            this.button_LogOut.TabIndex = 0;
            this.button_LogOut.Text = "Logout";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_ClientManagement
            // 
            this.button_ClientManagement.Location = new System.Drawing.Point(72, 293);
            this.button_ClientManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ClientManagement.Name = "button_ClientManagement";
            this.button_ClientManagement.Size = new System.Drawing.Size(235, 28);
            this.button_ClientManagement.TabIndex = 1;
            this.button_ClientManagement.Text = "Client Management";
            this.button_ClientManagement.UseVisualStyleBackColor = true;
            this.button_ClientManagement.Click += new System.EventHandler(this.button_ClientManagement_Click);
            // 
            // button_RoomManagement
            // 
            this.button_RoomManagement.Location = new System.Drawing.Point(440, 230);
            this.button_RoomManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RoomManagement.Name = "button_RoomManagement";
            this.button_RoomManagement.Size = new System.Drawing.Size(235, 28);
            this.button_RoomManagement.TabIndex = 2;
            this.button_RoomManagement.Text = "Room Management";
            this.button_RoomManagement.UseVisualStyleBackColor = true;
            this.button_RoomManagement.Click += new System.EventHandler(this.button_RoomManagement_Click);
            // 
            // button_ReservationManagement
            // 
            this.button_ReservationManagement.Location = new System.Drawing.Point(479, 364);
            this.button_ReservationManagement.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReservationManagement.Name = "button_ReservationManagement";
            this.button_ReservationManagement.Size = new System.Drawing.Size(235, 28);
            this.button_ReservationManagement.TabIndex = 3;
            this.button_ReservationManagement.Text = "Reservation Management";
            this.button_ReservationManagement.UseVisualStyleBackColor = true;
            this.button_ReservationManagement.Click += new System.EventHandler(this.button_ReservationManagement_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_ReservationManagement);
            this.Controls.Add(this.button_RoomManagement);
            this.Controls.Add(this.button_ClientManagement);
            this.Controls.Add(this.button_LogOut);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button_ReservationManagement;

        private System.Windows.Forms.Button button_RoomManagement;

        private System.Windows.Forms.Button button_ClientManagement;

        private System.Windows.Forms.Button button_LogOut;

        #endregion
    }
}