﻿using System.ComponentModel;

namespace PresentationLayer
{
    partial class AccommodationManagementForm
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
            this.dataGridView_AccommodationList = new System.Windows.Forms.DataGridView();
            this.textBox_PricePerDay = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.button_InsertAccommodation = new System.Windows.Forms.Button();
            this.button_DeleteAccommodation = new System.Windows.Forms.Button();
            this.button_UpdateAccommodation = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_AccommodationList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_AccommodationList
            // 
            this.dataGridView_AccommodationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccommodationList.Location = new System.Drawing.Point(404, 35);
            this.dataGridView_AccommodationList.Name = "dataGridView_AccommodationList";
            this.dataGridView_AccommodationList.Size = new System.Drawing.Size(568, 380);
            this.dataGridView_AccommodationList.TabIndex = 0;
            this.dataGridView_AccommodationList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AccommodationList_CellClick);
            // 
            // textBox_PricePerDay
            // 
            this.textBox_PricePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_PricePerDay.Location = new System.Drawing.Point(188, 200);
            this.textBox_PricePerDay.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PricePerDay.Name = "textBox_PricePerDay";
            this.textBox_PricePerDay.Size = new System.Drawing.Size(155, 22);
            this.textBox_PricePerDay.TabIndex = 50;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Name.Location = new System.Drawing.Point(188, 88);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(155, 22);
            this.textBox_Name.TabIndex = 47;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox_Id.Location = new System.Drawing.Point(188, 35);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(155, 29);
            this.textBox_Id.TabIndex = 46;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Email.Location = new System.Drawing.Point(26, 203);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(108, 16);
            this.label_Email.TabIndex = 45;
            this.label_Email.Text = "Price Per Day:";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_PhoneNumber.Location = new System.Drawing.Point(59, 165);
            this.label_PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(75, 16);
            this.label_PhoneNumber.TabIndex = 44;
            this.label_PhoneNumber.Text = "Category:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_LastName.Location = new System.Drawing.Point(81, 126);
            this.label_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(55, 16);
            this.label_LastName.TabIndex = 43;
            this.label_LastName.Text = "Status:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_FirstName.Location = new System.Drawing.Point(81, 88);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(53, 16);
            this.label_FirstName.TabIndex = 42;
            this.label_FirstName.Text = "Name:";
            this.label_FirstName.Click += new System.EventHandler(this.label_FirstName_Click);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Id.Location = new System.Drawing.Point(81, 35);
            this.label_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(33, 24);
            this.label_Id.TabIndex = 41;
            this.label_Id.Text = "Id:";
            // 
            // button_InsertAccommodation
            // 
            this.button_InsertAccommodation.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_InsertAccommodation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_InsertAccommodation.ForeColor = System.Drawing.SystemColors.Control;
            this.button_InsertAccommodation.Location = new System.Drawing.Point(89, 326);
            this.button_InsertAccommodation.Name = "button_InsertAccommodation";
            this.button_InsertAccommodation.Size = new System.Drawing.Size(203, 47);
            this.button_InsertAccommodation.TabIndex = 54;
            this.button_InsertAccommodation.Text = "Insert Accommodation";
            this.button_InsertAccommodation.UseVisualStyleBackColor = false;
            this.button_InsertAccommodation.Click += new System.EventHandler(this.button_InsertAccommodation_Click);
            // 
            // button_DeleteAccommodation
            // 
            this.button_DeleteAccommodation.BackColor = System.Drawing.Color.Firebrick;
            this.button_DeleteAccommodation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_DeleteAccommodation.ForeColor = System.Drawing.SystemColors.Control;
            this.button_DeleteAccommodation.Location = new System.Drawing.Point(199, 264);
            this.button_DeleteAccommodation.Name = "button_DeleteAccommodation";
            this.button_DeleteAccommodation.Size = new System.Drawing.Size(93, 47);
            this.button_DeleteAccommodation.TabIndex = 53;
            this.button_DeleteAccommodation.Text = "Delete";
            this.button_DeleteAccommodation.UseVisualStyleBackColor = false;
            this.button_DeleteAccommodation.Click += new System.EventHandler(this.button_DeleteAccommodation_Click);
            // 
            // button_UpdateAccommodation
            // 
            this.button_UpdateAccommodation.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_UpdateAccommodation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_UpdateAccommodation.ForeColor = System.Drawing.SystemColors.Control;
            this.button_UpdateAccommodation.Location = new System.Drawing.Point(89, 264);
            this.button_UpdateAccommodation.Name = "button_UpdateAccommodation";
            this.button_UpdateAccommodation.Size = new System.Drawing.Size(93, 47);
            this.button_UpdateAccommodation.TabIndex = 52;
            this.button_UpdateAccommodation.Text = "Update";
            this.button_UpdateAccommodation.UseVisualStyleBackColor = false;
            this.button_UpdateAccommodation.Click += new System.EventHandler(this.button_UpdateClient_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Close.Location = new System.Drawing.Point(879, 441);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(93, 47);
            this.button_Close.TabIndex = 51;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {"Available", "Booked"});
            this.comboBox_Status.Location = new System.Drawing.Point(188, 123);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(155, 24);
            this.comboBox_Status.TabIndex = 55;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Items.AddRange(new object[] {"Log Cabin", "Villa", "Cottage", "Bungalow"});
            this.comboBox_Category.Location = new System.Drawing.Point(188, 162);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(155, 24);
            this.comboBox_Category.TabIndex = 56;
            // 
            // AccommodationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(994, 500);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.button_InsertAccommodation);
            this.Controls.Add(this.button_DeleteAccommodation);
            this.Controls.Add(this.button_UpdateAccommodation);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.textBox_PricePerDay);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.dataGridView_AccommodationList);
            this.Name = "AccommodationManagementForm";
            this.Text = "Accommodation Management";
            this.Load += new System.EventHandler(this.AccommodationManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_AccommodationList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.ComboBox comboBox_Category;

        private System.Windows.Forms.Button button_InsertAccommodation;
        private System.Windows.Forms.Button button_DeleteAccommodation;
        private System.Windows.Forms.Button button_UpdateAccommodation;
        private System.Windows.Forms.Button button_Close;

        private System.Windows.Forms.TextBox textBox_PricePerDay;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_Id;

        private System.Windows.Forms.DataGridView dataGridView_AccommodationList;

        #endregion
    }
}