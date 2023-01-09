using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Shared.Interfaces;
using Shared.Models;

namespace PresentationLayer
{
    public partial class InsertClientForm : Form
    {
        private readonly IClientBusiness clientBusiness;
        
        public InsertClientForm(IClientBusiness _clientBusiness)
        {
            clientBusiness = _clientBusiness;
            InitializeComponent();
        }
        
        public ClientManagementForm RefClientManagementForm { get; set; }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_InsertClient_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "" || textBox_LastName.Text == ""  ||
                textBox_PhoneNumber.Text == "" || 
                textBox_Email.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                MessageBox.Show("E-mail entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Focus();
                return;
            }
            else if (!Regex.Match(textBox_FirstName.Text, @"^[A-Z]+[A-Za-z\s]{1,15}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("First name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_LastName.Text, @"^[A-Z]+[A-Za-z\s-]{1,30}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("Last name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_LastName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_PhoneNumber.Text, @"^[0][6]\d{7,8}$").Success)
            {
                MessageBox.Show("Phone number entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PhoneNumber.Focus();
                return;
            }
            else
            {
                Client client = new Client();
                client.FirstName = textBox_FirstName.Text;
                client.LastName = textBox_LastName.Text;
                client.PhoneNumber = textBox_PhoneNumber.Text;
                client.Email = textBox_Email.Text;
                string result = clientBusiness.InsertClient(client);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_PhoneNumber.Text = "";
                textBox_Email.Text = "";
            }
        }
    }
}