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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView_ClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ClientList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_ClientList.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.dataGridView_ClientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ClientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ClientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ClientList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ClientList.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            this.dataGridView_ClientList.Location = new System.Drawing.Point(28, 15);
            this.dataGridView_ClientList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ClientList.Name = "dataGridView_ClientList";
            this.dataGridView_ClientList.Size = new System.Drawing.Size(1009, 469);
            this.dataGridView_ClientList.TabIndex = 0;
            this.dataGridView_ClientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ClientList_CellClick);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (162)))), ((int) (((byte) (76)))));
            this.button_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Close.Location = new System.Drawing.Point(913, 769);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(124, 58);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Email.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_Email.Location = new System.Drawing.Point(831, 618);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(205, 26);
            this.textBox_Email.TabIndex = 40;
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(831, 567);
            this.textBox_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(205, 26);
            this.textBox_PhoneNumber.TabIndex = 36;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_LastName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_LastName.Location = new System.Drawing.Point(211, 614);
            this.textBox_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(205, 26);
            this.textBox_LastName.TabIndex = 34;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_FirstName.Location = new System.Drawing.Point(211, 575);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(205, 26);
            this.textBox_FirstName.TabIndex = 33;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Id.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_Id.Location = new System.Drawing.Point(211, 510);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(205, 34);
            this.textBox_Id.TabIndex = 32;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Email.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_Email.Location = new System.Drawing.Point(687, 622);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(69, 20);
            this.label_Email.TabIndex = 31;
            this.label_Email.Text = "E-mail:";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_PhoneNumber.Location = new System.Drawing.Point(609, 575);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(138, 20);
            this.label_PhoneNumber.TabIndex = 27;
            this.label_PhoneNumber.Text = "Phone Number:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_LastName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_LastName.Location = new System.Drawing.Point(28, 622);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(106, 20);
            this.label_LastName.TabIndex = 25;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_FirstName.Location = new System.Drawing.Point(28, 575);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(108, 20);
            this.label_FirstName.TabIndex = 24;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Id.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_Id.Location = new System.Drawing.Point(28, 510);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(42, 29);
            this.label_Id.TabIndex = 22;
            this.label_Id.Text = "Id:";
            // 
            // button_UpdateClient
            // 
            this.button_UpdateClient.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.button_UpdateClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_UpdateClient.ForeColor = System.Drawing.SystemColors.Control;
            this.button_UpdateClient.Location = new System.Drawing.Point(28, 668);
            this.button_UpdateClient.Margin = new System.Windows.Forms.Padding(4);
            this.button_UpdateClient.Name = "button_UpdateClient";
            this.button_UpdateClient.Size = new System.Drawing.Size(124, 58);
            this.button_UpdateClient.TabIndex = 41;
            this.button_UpdateClient.Text = "Update";
            this.button_UpdateClient.UseVisualStyleBackColor = false;
            this.button_UpdateClient.Click += new System.EventHandler(this.button_UpdateClient_Click);
            // 
            // button_DeleteClient
            // 
            this.button_DeleteClient.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            this.button_DeleteClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_DeleteClient.ForeColor = System.Drawing.SystemColors.Control;
            this.button_DeleteClient.Location = new System.Drawing.Point(175, 668);
            this.button_DeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.button_DeleteClient.Name = "button_DeleteClient";
            this.button_DeleteClient.Size = new System.Drawing.Size(124, 58);
            this.button_DeleteClient.TabIndex = 42;
            this.button_DeleteClient.Text = "Delete";
            this.button_DeleteClient.UseVisualStyleBackColor = false;
            this.button_DeleteClient.Click += new System.EventHandler(this.button_DeleteClient_Click);
            // 
            // button_InsertClient
            // 
            this.button_InsertClient.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.button_InsertClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_InsertClient.ForeColor = System.Drawing.SystemColors.Control;
            this.button_InsertClient.Location = new System.Drawing.Point(28, 769);
            this.button_InsertClient.Margin = new System.Windows.Forms.Padding(4);
            this.button_InsertClient.Name = "button_InsertClient";
            this.button_InsertClient.Size = new System.Drawing.Size(160, 58);
            this.button_InsertClient.TabIndex = 43;
            this.button_InsertClient.Text = "Insert Client";
            this.button_InsertClient.UseVisualStyleBackColor = false;
            this.button_InsertClient.Click += new System.EventHandler(this.button_InsertClient_Click);
            // 
            // ClientManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.ClientSize = new System.Drawing.Size(1051, 842);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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