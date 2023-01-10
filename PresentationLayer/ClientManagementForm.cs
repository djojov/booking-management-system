using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Shared.Interfaces;
using Shared.Models;

namespace PresentationLayer
{
    public partial class ClientManagementForm : Form
    {
        private readonly IClientBusiness clientBusiness;
        public ClientManagementForm(IClientBusiness _clientBusiness)
        {
            clientBusiness = _clientBusiness;
            InitializeComponent();
        }

        private void ClientManagementForm_Load_1(object sender, EventArgs e)
        {
            List<Client> clientsList = clientBusiness.GetAllClients();
            dataGridView_ClientList.DataSource = clientsList;
        }
        
        public DashboardForm RefDashboardForm { get; set; }

        private void button_Close_Click(object sender, EventArgs e)
        {
            RefDashboardForm.Refresh();
            this.RefDashboardForm.Show();
            this.Close();
        }

        private void dataGridView_ClientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView_ClientList.Rows[e.RowIndex];
                textBox_Id.Text = row.Cells[0].Value.ToString();
                textBox_FirstName.Text = row.Cells[1].Value.ToString();
                textBox_LastName.Text = row.Cells[2].Value.ToString();
                textBox_PhoneNumber.Text = row.Cells[4].Value.ToString();
                textBox_Email.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button_UpdateClient_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "" || textBox_LastName.Text == "" || textBox_PhoneNumber.Text == "" || textBox_Email.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
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
            else if (!Regex.Match(textBox_Email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                MessageBox.Show("E-mail entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Focus();
                return;
            }
            Client client = new Client();
            client.Id = Convert.ToInt32(textBox_Id.Text);
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.PhoneNumber = textBox_PhoneNumber.Text;
            client.Email = textBox_Email.Text;
            
            string result = clientBusiness.UpdateClient(client);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView_ClientList.DataSource = clientBusiness.GetAllClients();
        }

        private void button_InsertClient_Click(object sender, EventArgs e)
        {
            InsertClientForm insertClientForm = new InsertClientForm(clientBusiness);
            insertClientForm.RefClientManagementForm = this;
            insertClientForm.FormClosed += new FormClosedEventHandler(FormClose);
            insertClientForm.Show();
        }
        private void FormClose(object sender, EventArgs e)
        {
            dataGridView_ClientList.DataSource = clientBusiness.GetAllClients();
            this.Refresh();
        }

        private void button_DeleteClient_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "" || textBox_LastName.Text == "" || textBox_PhoneNumber.Text == "" || textBox_Email.Text == "")
            {
                MessageBox.Show("You have to select client", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else
            {
                int clientId = Convert.ToInt32(textBox_Id.Text);
                string result = clientBusiness.DeleteClient(clientId);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_ClientList.DataSource = clientBusiness.GetAllClients();
                
                textBox_Id.Text = "";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_PhoneNumber.Text = "";
                textBox_Email.Text = "";
                
            }
        }
    }
}