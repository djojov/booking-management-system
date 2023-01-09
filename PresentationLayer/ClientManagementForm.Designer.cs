using System.ComponentModel;

namespace PresentationLayer
{
    partial class ClientManagementForm
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
            this.dataGridView_ClientList = new System.Windows.Forms.DataGridView();
            this.button_Close = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.button_UpdateClient = new System.Windows.Forms.Button();
            this.button_DeleteClient = new System.Windows.Forms.Button();
            this.button_InsertClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_ClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ClientList
            // 
            this.dataGridView_ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClientList.Location = new System.Drawing.Point(21, 12);
            this.dataGridView_ClientList.Name = "dataGridView_ClientList";
            this.dataGridView_ClientList.Size = new System.Drawing.Size(757, 381);
            this.dataGridView_ClientList.TabIndex = 0;
            this.dataGridView_ClientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ClientList_CellClick);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Close.Location = new System.Drawing.Point(685, 625);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(93, 47);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Email.Location = new System.Drawing.Point(623, 502);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(155, 22);
            this.textBox_Email.TabIndex = 40;
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(623, 461);
            this.textBox_PhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(155, 22);
            this.textBox_PhoneNumber.TabIndex = 36;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_LastName.Location = new System.Drawing.Point(158, 499);
            this.textBox_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(155, 22);
            this.textBox_LastName.TabIndex = 34;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_FirstName.Location = new System.Drawing.Point(158, 467);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(155, 22);
            this.textBox_FirstName.TabIndex = 33;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Id.Location = new System.Drawing.Point(158, 414);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(155, 29);
            this.textBox_Id.TabIndex = 32;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Email.Location = new System.Drawing.Point(515, 505);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(56, 16);
            this.label_Email.TabIndex = 31;
            this.label_Email.Text = "E-mail:";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_PhoneNumber.Location = new System.Drawing.Point(457, 467);
            this.label_PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(114, 16);
            this.label_PhoneNumber.TabIndex = 27;
            this.label_PhoneNumber.Text = "Phone Number:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_LastName.Location = new System.Drawing.Point(21, 505);
            this.label_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(86, 16);
            this.label_LastName.TabIndex = 25;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_FirstName.Location = new System.Drawing.Point(21, 467);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(87, 16);
            this.label_FirstName.TabIndex = 24;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Id.Location = new System.Drawing.Point(21, 414);
            this.label_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(33, 24);
            this.label_Id.TabIndex = 22;
            this.label_Id.Text = "Id:";
            // 
            // button_UpdateClient
            // 
            this.button_UpdateClient.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_UpdateClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_UpdateClient.ForeColor = System.Drawing.SystemColors.Control;
            this.button_UpdateClient.Location = new System.Drawing.Point(21, 543);
            this.button_UpdateClient.Name = "button_UpdateClient";
            this.button_UpdateClient.Size = new System.Drawing.Size(93, 47);
            this.button_UpdateClient.TabIndex = 41;
            this.button_UpdateClient.Text = "Update";
            this.button_UpdateClient.UseVisualStyleBackColor = false;
            this.button_UpdateClient.Click += new System.EventHandler(this.button_UpdateClient_Click);
            // 
            // button_DeleteClient
            // 
            this.button_DeleteClient.BackColor = System.Drawing.Color.Firebrick;
            this.button_DeleteClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_DeleteClient.ForeColor = System.Drawing.SystemColors.Control;
            this.button_DeleteClient.Location = new System.Drawing.Point(131, 543);
            this.button_DeleteClient.Name = "button_DeleteClient";
            this.button_DeleteClient.Size = new System.Drawing.Size(93, 47);
            this.button_DeleteClient.TabIndex = 42;
            this.button_DeleteClient.Text = "Delete";
            this.button_DeleteClient.UseVisualStyleBackColor = false;
            this.button_DeleteClient.Click += new System.EventHandler(this.button_DeleteClient_Click);
            // 
            // button_InsertClient
            // 
            this.button_InsertClient.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_InsertClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_InsertClient.ForeColor = System.Drawing.SystemColors.Control;
            this.button_InsertClient.Location = new System.Drawing.Point(21, 625);
            this.button_InsertClient.Name = "button_InsertClient";
            this.button_InsertClient.Size = new System.Drawing.Size(120, 47);
            this.button_InsertClient.TabIndex = 43;
            this.button_InsertClient.Text = "Insert Client";
            this.button_InsertClient.UseVisualStyleBackColor = false;
            this.button_InsertClient.Click += new System.EventHandler(this.button_InsertClient_Click);
            // 
            // ClientManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(788, 684);
            this.Controls.Add(this.button_InsertClient);
            this.Controls.Add(this.button_DeleteClient);
            this.Controls.Add(this.button_UpdateClient);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.dataGridView_ClientList);
            this.Name = "ClientManagementForm";
            this.Text = "Client Management";
            this.Load += new System.EventHandler(this.ClientManagementForm_Load_1);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_ClientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_InsertClient;

        private System.Windows.Forms.Button button_UpdateClient;
        private System.Windows.Forms.Button button_DeleteClient;

        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_Id;

        private System.Windows.Forms.Button button_Close;

        private System.Windows.Forms.DataGridView dataGridView_ClientList;

        #endregion
    }
}