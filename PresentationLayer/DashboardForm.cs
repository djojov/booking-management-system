using System;
using System.Linq;
using System.Windows.Forms;
using Shared.Interfaces;
using Shared.Models;

namespace PresentationLayer
{
    public partial class DashboardForm : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        private readonly IAccommodationBusiness accommodationBusiness;
        private readonly IReservationBusiness reservationBusiness;
        Admin admin;
        
        public DashboardForm(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness, IAccommodationBusiness _accommodationBusiness, IReservationBusiness _reservationBusiness, Admin _admin)
        {
            admin = _admin;
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            accommodationBusiness = _accommodationBusiness;
            reservationBusiness = _reservationBusiness;
            InitializeComponent();
        }
        
        public LoginForm RefLoginForm { get; set; }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.RefLoginForm.Show();
            this.Close();
        }

        private void button_ClientManagement_Click(object sender, EventArgs e)
        {
            ClientManagementForm clientManagementForm = new ClientManagementForm(clientBusiness);
            clientManagementForm.RefDashboardForm = this;
            clientManagementForm.FormClosed += new FormClosedEventHandler(FormClose);
            clientManagementForm.Show();
            this.Hide();
        }
        
        private void FormClose(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button_RoomManagement_Click(object sender, EventArgs e)
        {
            AccommodationManagementForm accommodationManagementForm = new AccommodationManagementForm(accommodationBusiness);
            accommodationManagementForm.RefDashboardForm = this;
            accommodationManagementForm.FormClosed += new FormClosedEventHandler(FormClose);
            accommodationManagementForm.Show();
            this.Hide();
        }

        private void button_ReservationManagement_Click(object sender, EventArgs e)
        {
            ReservationManagementForm reservationManagementForm = new ReservationManagementForm(reservationBusiness, clientBusiness, accommodationBusiness);
            reservationManagementForm.RefDashboardForm = this;
            reservationManagementForm.FormClosed += new FormClosedEventHandler(FormClose);
            reservationManagementForm.Show();
            this.Hide();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            textBox_NumberOfAccommodations.Text = accommodationBusiness.GetAllAccommodations().Count.ToString();
            textBox_FreeAccommodations.Text = accommodationBusiness.GetAllAccommodations().Count(t => t.Status=="Available").ToString();
            textBox_NumberOfClients.Text = clientBusiness.GetAllClients().Count.ToString();
        }

        private void textBox_NumberOfClients_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}