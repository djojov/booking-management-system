﻿using System;
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
        Admin admin;
        
        public DashboardForm(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness, IAccommodationBusiness _accommodationBusiness, Admin _admin)
        {
            admin = _admin;
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            accommodationBusiness = _accommodationBusiness;
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
    }
}