using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Shared.Interfaces;
using Shared.Models;

namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        private readonly IAccommodationBusiness accommodationBusiness;
        private readonly IReservationBusiness reservationBusiness;

        public LoginForm(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness, IAccommodationBusiness _accommodationBusiness, IReservationBusiness _reservationBusiness)
        {
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            accommodationBusiness = _accommodationBusiness;
            reservationBusiness = _reservationBusiness;
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("You have to enter e-mail and password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBox_Password.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$").Success)
            {
                MessageBox.Show("Password entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Password.Focus();
                return;
            }
            
            Admin admin = adminBusiness.GetAdmin(textBox_Username.Text, textBox_Password.Text);
            if (admin.Id == 0 )
            { 
                MessageBox.Show("There is no admin with that e-mail and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DashboardForm dashboardForm = new DashboardForm(adminBusiness,clientBusiness, accommodationBusiness, reservationBusiness, admin);
                dashboardForm.RefLoginForm = this;
                this.Hide();
                dashboardForm.Show();
                textBox_Username.Text = "";
                textBox_Password.Text = "";
                textBox_Username.Focus();
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}