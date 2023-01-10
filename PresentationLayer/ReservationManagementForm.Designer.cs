using System.ComponentModel;

namespace PresentationLayer
{
    partial class ReservationManagementForm
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
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.comboBox_Accommodation = new System.Windows.Forms.ComboBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_DateIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DateOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button_InsertReservation = new System.Windows.Forms.Button();
            this.button_DeleteAccommodation = new System.Windows.Forms.Button();
            this.dataGridView_ReservationList = new System.Windows.Forms.DataGridView();
            this.button_Close = new System.Windows.Forms.Button();
            this.textBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_ReservationList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_Client.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(349, 84);
            this.comboBox_Client.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(253, 28);
            this.comboBox_Client.TabIndex = 62;
            // 
            // comboBox_Accommodation
            // 
            this.comboBox_Accommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_Accommodation.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.comboBox_Accommodation.FormattingEnabled = true;
            this.comboBox_Accommodation.Location = new System.Drawing.Point(140, 84);
            this.comboBox_Accommodation.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Accommodation.Name = "comboBox_Accommodation";
            this.comboBox_Accommodation.Size = new System.Drawing.Size(167, 28);
            this.comboBox_Accommodation.TabIndex = 61;
            this.comboBox_Accommodation.SelectedIndexChanged += new System.EventHandler(this.comboBox_Accommodation_SelectedIndexChanged);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Id.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.textBox_Id.Location = new System.Drawing.Point(32, 77);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(85, 34);
            this.textBox_Id.TabIndex = 60;
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_PhoneNumber.Location = new System.Drawing.Point(349, 55);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(64, 20);
            this.label_PhoneNumber.TabIndex = 59;
            this.label_PhoneNumber.Text = "Client:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_LastName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_LastName.Location = new System.Drawing.Point(140, 55);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(148, 20);
            this.label_LastName.TabIndex = 58;
            this.label_LastName.Text = "Accommodation:";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Id.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label_Id.Location = new System.Drawing.Point(32, 55);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(30, 20);
            this.label_Id.TabIndex = 57;
            this.label_Id.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label1.Location = new System.Drawing.Point(673, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Date in:";
            // 
            // dateTimePicker_DateIn
            // 
            this.dateTimePicker_DateIn.CalendarForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.dateTimePicker_DateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateIn.Location = new System.Drawing.Point(673, 85);
            this.dateTimePicker_DateIn.Name = "dateTimePicker_DateIn";
            this.dateTimePicker_DateIn.Size = new System.Drawing.Size(116, 22);
            this.dateTimePicker_DateIn.TabIndex = 64;
            this.dateTimePicker_DateIn.ValueChanged += new System.EventHandler(this.dateTimePicker_DateIn_ValueChanged);
            // 
            // dateTimePicker_DateOut
            // 
            this.dateTimePicker_DateOut.CalendarForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.dateTimePicker_DateOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateOut.Location = new System.Drawing.Point(827, 85);
            this.dateTimePicker_DateOut.Name = "dateTimePicker_DateOut";
            this.dateTimePicker_DateOut.Size = new System.Drawing.Size(116, 22);
            this.dateTimePicker_DateOut.TabIndex = 65;
            this.dateTimePicker_DateOut.ValueChanged += new System.EventHandler(this.dateTimePicker_DateOut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.label2.Location = new System.Drawing.Point(827, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Date out:";
            // 
            // button_InsertReservation
            // 
            this.button_InsertReservation.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (115)))), ((int) (((byte) (189)))), ((int) (((byte) (168)))));
            this.button_InsertReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_InsertReservation.ForeColor = System.Drawing.SystemColors.Control;
            this.button_InsertReservation.Location = new System.Drawing.Point(292, 169);
            this.button_InsertReservation.Margin = new System.Windows.Forms.Padding(4);
            this.button_InsertReservation.Name = "button_InsertReservation";
            this.button_InsertReservation.Size = new System.Drawing.Size(271, 58);
            this.button_InsertReservation.TabIndex = 69;
            this.button_InsertReservation.Text = "Book accommodation";
            this.button_InsertReservation.UseVisualStyleBackColor = false;
            this.button_InsertReservation.Click += new System.EventHandler(this.button_InsertReservation_Click);
            // 
            // button_DeleteAccommodation
            // 
            this.button_DeleteAccommodation.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            this.button_DeleteAccommodation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_DeleteAccommodation.ForeColor = System.Drawing.SystemColors.Control;
            this.button_DeleteAccommodation.Location = new System.Drawing.Point(819, 169);
            this.button_DeleteAccommodation.Margin = new System.Windows.Forms.Padding(4);
            this.button_DeleteAccommodation.Name = "button_DeleteAccommodation";
            this.button_DeleteAccommodation.Size = new System.Drawing.Size(124, 58);
            this.button_DeleteAccommodation.TabIndex = 68;
            this.button_DeleteAccommodation.Text = "Delete";
            this.button_DeleteAccommodation.UseVisualStyleBackColor = false;
            this.button_DeleteAccommodation.Click += new System.EventHandler(this.button_DeleteAccommodation_Click);
            // 
            // dataGridView_ReservationList
            // 
            this.dataGridView_ReservationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ReservationList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_ReservationList.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            this.dataGridView_ReservationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ReservationList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ReservationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ReservationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (111)))), ((int) (((byte) (86)))), ((int) (((byte) (67)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ReservationList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ReservationList.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (107)))), ((int) (((byte) (73)))));
            this.dataGridView_ReservationList.Location = new System.Drawing.Point(32, 267);
            this.dataGridView_ReservationList.Name = "dataGridView_ReservationList";
            this.dataGridView_ReservationList.RowTemplate.Height = 24;
            this.dataGridView_ReservationList.Size = new System.Drawing.Size(911, 449);
            this.dataGridView_ReservationList.TabIndex = 0;
            this.dataGridView_ReservationList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ReservationList_CellClick);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (210)))), ((int) (((byte) (162)))), ((int) (((byte) (76)))));
            this.button_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Close.Location = new System.Drawing.Point(819, 761);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(124, 58);
            this.button_Close.TabIndex = 71;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_TotalPrice
            // 
            this.textBox_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_TotalPrice.Location = new System.Drawing.Point(106, 175);
            this.textBox_TotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TotalPrice.Name = "textBox_TotalPrice";
            this.textBox_TotalPrice.ReadOnly = true;
            this.textBox_TotalPrice.Size = new System.Drawing.Size(90, 41);
            this.textBox_TotalPrice.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(32, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "Total:";
            // 
            // ReservationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (236)))), ((int) (((byte) (230)))), ((int) (((byte) (194)))));
            this.ClientSize = new System.Drawing.Size(964, 845);
            this.Controls.Add(this.textBox_TotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.dataGridView_ReservationList);
            this.Controls.Add(this.button_InsertReservation);
            this.Controls.Add(this.button_DeleteAccommodation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_DateOut);
            this.Controls.Add(this.dateTimePicker_DateIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Client);
            this.Controls.Add(this.comboBox_Accommodation);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Management";
            this.Load += new System.EventHandler(this.ReservationManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_ReservationList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox_TotalPrice;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button button_Close;

        private System.Windows.Forms.Button button_InsertReservation;
        private System.Windows.Forms.Button button_DeleteAccommodation;
        private System.Windows.Forms.DataGridView dataGridView_ReservationList;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOut;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.ComboBox comboBox_Accommodation;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_Id;

        #endregion
    }
}