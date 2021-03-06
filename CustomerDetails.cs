using HotelBookingDemo.Subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingDemo
{
    public partial class CustomerDetails : Form
    {
        int nightsBeingBooked = 1; //used to calculate price of the guest's stay at the hotel
        public static string name = "";
        public static string surname = "";
        public static string address = "";
        public static string email = "";
        public static string phone = "";

        public static double totalPrice; //This calculates totalPrice by multiplying room price by nightsbeingbooked

        private readonly double totalDouble = RoomBuilder.totalPrice;

        private readonly Regex validation = new Regex("[a-zA-Z0-9]");//adding basic regular expression that accepts all letters and all numbers to avoid user from crashing the application

        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            string totalPrice = RoomBuilder.total;        //getting the price from label using the public static string in room builder form
            lblDisplayTotal.Text = totalPrice.ToString();
            txtNoOfNights.Text = "1";
        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            name = txtFirstName.Text;
            surname = txtLastName.Text;
            address = txtAddress.Text;
            email = txtEmail.Text;
            phone = txtPhone.Text;
            nightsBeingBooked = int.Parse(txtNoOfNights.Text);

            if (validation.IsMatch(name) && validation.IsMatch(surname) && validation.IsMatch(address) && validation.IsMatch(email) && validation.IsMatch(phone))
            {//Calling the Regex method IsMatch() here to validate the form
                MessageBox.Show("Your booking has been received, please see your email for booking details!");

                Customer customer = new Customer(name, surname, address, email, phone, nightsBeingBooked);
                SendEmail(customer.Email);
                CustomerList.AddCustomerToList(customer);

                HotelAdminNotifications hotelAdminNotifications = new HotelAdminNotifications();
                hotelAdminNotifications.UpdateBooking();
                hotelAdminNotifications.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Please fill out all fields to make a reservation!");
            }

        }

        public void SendEmail(string email) //this method sends a booking confirmation email to the user
        {
            totalPrice = totalDouble * nightsBeingBooked;

            try
            {
                var senderEmail = new MailAddress("ENTER_YOUR_EMAIL_HERE", "Hotel Demo");
                var receiverEmail = new MailAddress(email);
                var password = "ENTER_YOUR_PASSWORD_HERE";
                var smtp = new SmtpClient
                {
                    Host = "smtp.outlook.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using
                    (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = "Hotel Booking Confirmation",
                        Body = "Hello " + name + " " + surname + ","
                                + "\n\nThank you for booking your stay with us. Here is confirmation of your booking information."
                                + "\n\nBooking Details:  "
                                + "\n\n           Name: " + name.ToUpper() + " " + surname.ToUpper()
                                + "\n           Phone Number: " + phone
                                + "\n           Email: " + email.ToUpper()
                                + "\n           Number of nights: " + nightsBeingBooked + " "
                                + "\n           Total price: " + totalPrice.ToString() 
                                + "\n           Booking Date: " + DateTime.Now.ToString()
                                + "\n\nWe look forward to your visit!"
                                + "\nHotel Management."
                                + "\n\n\n\nThis email has been automatically generated by an application."
                                + "\nIt is intended for app demonstration purposes only."
                                + "\nPlease contact " 
                                + "ENTER_YOUR_EMAIL_HERE" 
                                + " with any queries."
                    }
                    )

                {
                    smtp.Send(mess);
                }
            }
            catch
            {

            }
        }


        private void ButtonAddNights_Click(object sender, EventArgs e)
        {
            nightsBeingBooked++;//adds nights
            txtNoOfNights.Text = nightsBeingBooked.ToString();
            totalPrice = totalDouble * nightsBeingBooked;
            lblDisplayTotal.Text = "€" + totalPrice.ToString();//we calculate total price by multiplying Room total price by nightsBeingBooked(nights)
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            nightsBeingBooked--;//removes nights
            if (nightsBeingBooked == 0)//after testing we realized that we could make a booking for 0 nights
            {
                nightsBeingBooked = 1;//therefore we told the program to reset nightsBeingBooked to 1 if nightsBeingBooked reached 0
            }
            txtNoOfNights.Text = nightsBeingBooked.ToString();            
            totalPrice = totalDouble * nightsBeingBooked;
            lblDisplayTotal.Text = "€" + totalPrice.ToString();//we calculate total price by multiplying Room total price by nightsBeingBooked(nights)
        }

        private void ButtonBackToRooms_Click(object sender, EventArgs e)
        {
            RoomBuilder roombuild = new RoomBuilder();
            this.Hide();
            roombuild.Show();
        }
    }
}
