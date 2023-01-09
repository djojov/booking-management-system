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
            this.SuspendLayout();
            // 
            // button_LogOut
            // 
            this.button_LogOut.Location = new System.Drawing.Point(684, 404);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(75, 23);
            this.button_LogOut.TabIndex = 0;
            this.button_LogOut.Text = "Logout";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_ClientManagement
            // 
            this.button_ClientManagement.Location = new System.Drawing.Point(54, 238);
            this.button_ClientManagement.Name = "button_ClientManagement";
            this.button_ClientManagement.Size = new System.Drawing.Size(176, 23);
            this.button_ClientManagement.TabIndex = 1;
            this.button_ClientManagement.Text = "Client Management";
            this.button_ClientManagement.UseVisualStyleBackColor = true;
            this.button_ClientManagement.Click += new System.EventHandler(this.button_ClientManagement_Click);
            // 
            // button_RoomManagement
            // 
            this.button_RoomManagement.Location = new System.Drawing.Point(330, 187);
            this.button_RoomManagement.Name = "button_RoomManagement";
            this.button_RoomManagement.Size = new System.Drawing.Size(176, 23);
            this.button_RoomManagement.TabIndex = 2;
            this.button_RoomManagement.Text = "Room Management";
            this.button_RoomManagement.UseVisualStyleBackColor = true;
            this.button_RoomManagement.Click += new System.EventHandler(this.button_RoomManagement_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_RoomManagement);
            this.Controls.Add(this.button_ClientManagement);
            this.Controls.Add(this.button_LogOut);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button_RoomManagement;

        private System.Windows.Forms.Button button_ClientManagement;

        private System.Windows.Forms.Button button_LogOut;

        #endregion
    }
}