using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared.Interfaces;
using Shared.Models;

namespace PresentationLayer
{
    public partial class ReservationManagementForm : Form
    {
        private readonly IReservationBusiness reservationBusiness;
        private readonly IClientBusiness clientBusiness;
        private readonly IAccommodationBusiness accommodationBusiness;
        public ReservationManagementForm(IReservationBusiness _reservationBusiness, IClientBusiness _clientBusiness, IAccommodationBusiness _accommodationBusiness)
        {
            reservationBusiness = _reservationBusiness;
            clientBusiness = _clientBusiness;
            accommodationBusiness = _accommodationBusiness;
            InitializeComponent();
        }
        
        public DashboardForm RefDashboardForm { get; set; }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.RefDashboardForm.Show();
            this.Close();
            RefDashboardForm.Refresh();
        }

        private void ReservationManagementForm_Load(object sender, EventArgs e)
        {
            List<Reservation> resrvationList = reservationBusiness.GetAllReservations();
            dataGridView_ReservationList.DataSource = resrvationList;
            
            List<String> accommodations = accommodationBusiness.GetAllAccommodations().Where(t => t.Status=="Available").Select(t => t.Id + " — " + t.Category).ToList();
            List<String> clients = clientBusiness.GetAllClients().Select(c => c.Id + " — " + c.FirstName + " " + c.LastName).ToList();
            comboBox_Accommodation.DataSource=accommodations;
            comboBox_Client.DataSource=clients;
        }

        private void dataGridView_ReservationList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView_ReservationList.Rows[e.RowIndex];
                textBox_Id.Text = row.Cells[0].Value.ToString();
                comboBox_Accommodation.Text = row.Cells[1].Value.ToString();
                comboBox_Client.Text = row.Cells[2].Value.ToString();
                dateTimePicker_DateIn.Text = row.Cells[3].Value.ToString();
                dateTimePicker_DateOut.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button_InsertReservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            
            string[] splitted_Accommodation = comboBox_Accommodation.Text.Split(' ');
            reservation.AccommodationId = Convert.ToInt32(splitted_Accommodation[0]);
            
            string[] splitted_Client = comboBox_Client.Text.Split(' ');
            reservation.ClientId = Convert.ToInt32(splitted_Client[0]);

            reservation.DateIn = dateTimePicker_DateIn.Value;
            reservation.DateOut = dateTimePicker_DateOut.Value;
            
            string result = reservationBusiness.InsertReservation(reservation);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<Accommodation> temp = accommodationBusiness.GetAllAccommodations().Where(a => a.Id == Convert.ToInt32(splitted_Accommodation[0])).ToList();
            temp[0].Status = "Booked";
            accommodationBusiness.UpdateAccommodation(temp[0]);
            
            List<String> accommodations = accommodationBusiness.GetAllAccommodations().Where(t => t.Status=="Available").Select(t => t.Id + " — " + t.Category).ToList();
            List<String> clients = clientBusiness.GetAllClients().Select(c => c.Id + " — " + c.FirstName + " " + c.LastName).ToList();
            comboBox_Accommodation.DataSource=accommodations;
            comboBox_Client.DataSource=clients;
            dataGridView_ReservationList.DataSource = reservationBusiness.GetAllReservations();
        }

        private void button_DeleteAccommodation_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            
            string[] splitted_Accommodation = comboBox_Accommodation.Text.Split(' ');
            reservation.AccommodationId = Convert.ToInt32(splitted_Accommodation[0]);
            
            string[] splitted_Client = comboBox_Client.Text.Split(' ');
            reservation.ClientId = Convert.ToInt32(splitted_Client[0]);

            reservation.DateIn = dateTimePicker_DateIn.Value;
            reservation.DateOut = dateTimePicker_DateOut.Value;
            
            string result = reservationBusiness.DeleteReservation(Convert.ToInt32(textBox_Id.Text));
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            List<Accommodation> temp = accommodationBusiness.GetAllAccommodations().Where(a => a.Id == Convert.ToInt32(splitted_Accommodation[0])).ToList();
            temp[0].Status = "Available";
            accommodationBusiness.UpdateAccommodation(temp[0]);
            
            List<String> accommodations = accommodationBusiness.GetAllAccommodations().Where(t => t.Status=="Available").Select(t => t.Id + " — " + t.Category).ToList();
            List<String> clients = clientBusiness.GetAllClients().Select(c => c.Id + " — " + c.FirstName + " " + c.LastName).ToList();
            comboBox_Accommodation.DataSource=accommodations;
            comboBox_Client.DataSource=clients;
            dataGridView_ReservationList.DataSource = reservationBusiness.GetAllReservations();
        }

        private void comboBox_Accommodation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] splitted_Accommodation = comboBox_Accommodation.Text.Split(' ');
            List<Accommodation> temp1 = accommodationBusiness.GetAllAccommodations().Where(a => a.Id == Convert.ToInt32(splitted_Accommodation[0])).ToList();
            
            var dateIn = dateTimePicker_DateIn.Value;
            var dateOut = dateTimePicker_DateOut.Value;
            var numberOfDays = dateOut - dateIn;
            int total = temp1[0].PricePerDay * numberOfDays.Days;
            textBox_TotalPrice.Text = Convert.ToString(total + "€");
        }

        private void dateTimePicker_DateIn_ValueChanged(object sender, EventArgs e)
        {
            string[] splitted_Accommodation = comboBox_Accommodation.Text.Split(' ');
            List<Accommodation> temp1 = accommodationBusiness.GetAllAccommodations().Where(a => a.Id == Convert.ToInt32(splitted_Accommodation[0])).ToList();
            
            var dateIn = dateTimePicker_DateIn.Value;
            var dateOut = dateTimePicker_DateOut.Value;
            var numberOfDays = dateOut - dateIn;
            int total = temp1[0].PricePerDay * numberOfDays.Days;
            textBox_TotalPrice.Text = Convert.ToString(total + "€");
        }

        private void dateTimePicker_DateOut_ValueChanged(object sender, EventArgs e)
        {
            string[] splitted_Accommodation = comboBox_Accommodation.Text.Split(' ');
            List<Accommodation> temp1 = accommodationBusiness.GetAllAccommodations().Where(a => a.Id == Convert.ToInt32(splitted_Accommodation[0])).ToList();
            
            var dateIn = dateTimePicker_DateIn.Value;
            var dateOut = dateTimePicker_DateOut.Value;
            var numberOfDays = dateOut - dateIn;
            int total = temp1[0].PricePerDay * numberOfDays.Days;
            textBox_TotalPrice.Text = Convert.ToString(total + "€");
        }
    }
}