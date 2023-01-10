using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Shared.Interfaces;
using Shared.Models;

namespace PresentationLayer
{
    public partial class AccommodationManagementForm : Form
    {
        private readonly IAccommodationBusiness accommodationBusiness;
        public AccommodationManagementForm(IAccommodationBusiness _accommodationBusiness)
        {
            accommodationBusiness = _accommodationBusiness;
            InitializeComponent();
        }

        private void AccommodationManagementForm_Load(object sender, EventArgs e)
        {
            List<Accommodation> accommodationsList = accommodationBusiness.GetAllAccommodations();
            dataGridView_AccommodationList.DataSource = accommodationsList;
        }
        
        public DashboardForm RefDashboardForm { get; set; }

        private void button_Close_Click(object sender, EventArgs e)
        {
            RefDashboardForm.Refresh();
            this.RefDashboardForm.Show();
            this.Close();
        }
        
        private void dataGridView_AccommodationList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGridView_AccommodationList.Rows[e.RowIndex];
                textBox_Id.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                
                if(row.Cells[2].Value.ToString() == "Available")
                    comboBox_Status.SelectedIndex = 0;
                else
                    comboBox_Status.SelectedIndex = 1;
                
                if(row.Cells[3].Value.ToString() == "Log Cabin")
                    comboBox_Category.SelectedIndex = 0;
                else if(row.Cells[3].Value.ToString() == "Villa")
                    comboBox_Category.SelectedIndex = 1;
                else if(row.Cells[3].Value.ToString() == "Cottage")
                    comboBox_Category.SelectedIndex = 2;
                else
                    comboBox_Category.SelectedIndex = 3;
                
                
                textBox_PricePerDay.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button_UpdateClient_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_PricePerDay.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Name.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Name.Text, @"^[A-Z]+[A-Za-z\s]{1,15}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("Name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Name.Focus();
                return;
            }
            else if (!Regex.Match(textBox_PricePerDay.Text, @"^[0-9]*$").Success)
            {
                MessageBox.Show("Price per day must be a number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PricePerDay.Focus();
                return;
            }
            Accommodation accommodation = new Accommodation();
            accommodation.Id = Convert.ToInt32(textBox_Id.Text);
            accommodation.Name = textBox_Name.Text;

            if (comboBox_Status.SelectedItem.ToString() == "Available")
                accommodation.Status = "Available";
            else
                accommodation.Status = "Booked";
            
            if (comboBox_Category.SelectedItem.ToString() == "Log Cabin")
                accommodation.Category = "Log Cabin";
            else if(comboBox_Category.SelectedItem.ToString() == "Villa")
                accommodation.Category = "Villa";
            else if(comboBox_Category.SelectedItem.ToString() == "Cottage")
                accommodation.Category = "Cottage";
            else
                accommodation.Category = "Bungalow";
            
            accommodation.PricePerDay = Convert.ToInt32(textBox_PricePerDay.Text);
            
            string result = accommodationBusiness.UpdateAccommodation(accommodation);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView_AccommodationList.DataSource = accommodationBusiness.GetAllAccommodations();
        }

        private void button_DeleteAccommodation_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_PricePerDay.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Name.Focus();
                return;
            }
            else
            {
                int accommodationId = Convert.ToInt32(textBox_Id.Text);
                string result = accommodationBusiness.DeleteAccommodation(accommodationId);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_AccommodationList.DataSource = accommodationBusiness.GetAllAccommodations();
                
                textBox_Id.Text = "";
                textBox_Name.Text = "";
                textBox_PricePerDay.Text = "";
                comboBox_Category.SelectedIndex = -1;
                comboBox_Status.SelectedIndex = -1;
            }
        }

        private void button_InsertAccommodation_Click(object sender, EventArgs e)
        {
            InsertAccommodationForm insertAccommodationForm = new InsertAccommodationForm(accommodationBusiness);
            insertAccommodationForm.RefAccommodationManagementForm = this;
            insertAccommodationForm.FormClosed += new FormClosedEventHandler(FormClose);
            insertAccommodationForm.Show();
        }
        private void FormClose(object sender, EventArgs e)
        {
            dataGridView_AccommodationList.DataSource = accommodationBusiness.GetAllAccommodations();
            this.Refresh();
        }

        private void label_FirstName_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}