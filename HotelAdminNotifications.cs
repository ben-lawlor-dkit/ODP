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

namespace HotelBookingDemo
{
    public partial class HotelAdminNotifications : Form
    {
        
        public HotelAdminNotifications()
        {           
            InitializeComponent();            
        }

        public void UpdateBooking()
        {           
            foreach (Customer c in CustomerList.customers_list)
            {
                dataGridView1.Rows.Add(c.Name, c.Surname, c.Address, c.Email, c.Phone, c.NightsBooked.ToString() + " nights"); ;
            }              
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Home.ActiveForm == null)
            {
                Home home = new Home();
                home.Show();
            }
        }
    }
}
