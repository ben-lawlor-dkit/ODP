using HotelBookingDemo.Subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this application was developed by Mark, Ginta and Ben 
namespace HotelBookingDemo
{
    
    public partial class Home : Form
    {
       // private Rooms booking;
        //HotelAdminNotifications bookings = new HotelAdminNotifications();
        
        public Home()
        {
            InitializeComponent();
        }

        private void ButtonStandardRoom_Click(object sender, EventArgs e)
        {
            RoomBuilder roomBuilder = new RoomBuilder();//brings the user to room builder form which uses decorator pattern
            roomBuilder.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {                            
            LabelPromoDeal.Visible = false; 
        }

        private void ButtonDeluxeRoom_Click(object sender, EventArgs e)
        {
            RoomBuilder roomBuilder = new RoomBuilder();
            roomBuilder.Show();
        }

        private void ButtonBook_Click(object sender, EventArgs e)
        {
            RoomBuilder roomBuilder = new RoomBuilder();
            roomBuilder.Show();
            this.Hide();

           // CustomerArray cust = new CustomerArray("Test"," Test","Test","Test","Test");//we did add a customer class and initially was used for the second observer pattern
            //booking.LoadForm(cust);                                           //to notify hotel admin of customer booking

        }

        private void ButtonDisplayDeals_Click(object sender, EventArgs e)
        {
            string promo = AdminPromoDeals.promodeal;//pulls the information out from admin from textbox and displays it in the main start up form
            LabelPromoDeal.Text = promo; //one of the challenges we experienced when testing was how to pull information out from one form into another
            LabelPromoDeal.Visible = true;
        }

        private void ButtonBookings_Click(object sender, EventArgs e)
        {
            HotelAdminNotifications hotelAdminNotifications = new HotelAdminNotifications();
            hotelAdminNotifications.UpdateBooking();
            hotelAdminNotifications.Show();
        }

        private void ButtonAddPromo_Click(object sender, EventArgs e)
        {
            AdminPromoDeals promo = new AdminPromoDeals();//runs the admin promo deal notification form 
            promo.Show();                                 //which uses the observer pattern
                                                          //to send promotional deals
                                                          //to email addresses for current bookings
        }
    }
}
