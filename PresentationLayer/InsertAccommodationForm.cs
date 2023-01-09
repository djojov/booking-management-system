using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Shared.Interfaces;
using Shared.Models;

namespace PresentationLayer
{
    public partial class InsertAccommodationForm : Form
    {
        private readonly IAccommodationBusiness accommodationBusiness;
        public InsertAccommodationForm(IAccommodationBusiness _accommodationBusiness)
        {
            accommodationBusiness = _accommodationBusiness;
            InitializeComponent();
        }
        
        public AccommodationManagementForm RefAccommodationManagementForm { get; set; }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_InsertClient_Click(object sender, EventArgs e)
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
            else
            {
                Accommodation accommodation = new Accommodation();
                accommodation.Name = textBox_Name.Text;
                accommodation.PricePerDay = Convert.ToInt32(textBox_PricePerDay.Text);
                accommodation.Status = comboBox_Status.SelectedItem.ToString();
                accommodation.Category = comboBox_Category.SelectedItem.ToString();
                
                string result = accommodationBusiness.InsertAccommodation(accommodation);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox_Name.Text = "";
                textBox_PricePerDay.Text = "";
                comboBox_Category.SelectedIndex = -1;
                comboBox_Status.SelectedIndex = -1;
            }
        }
    }
}