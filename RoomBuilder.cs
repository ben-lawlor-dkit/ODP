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
using HotelBookingDemo.Subjects.Decorator;

namespace HotelBookingDemo
{
    public partial class RoomBuilder : Form
    {
        public static string total; //declaring public static string at an elevated class level in order
                                    //to be able to retrieve the information from other forms in the project
        public static double totalPrice;

        public RoomBuilder()
        {
            InitializeComponent();
        }

        IRoom _room = new StandardRoom();

        private void RadioButtonStandard_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxBreakfast.Checked = false;
            CheckBoxDinner.Checked = false;
            _room = new StandardRoom();
            DisplayPrice();
            CheckBoxBreakfast.Enabled = true;
            CheckBoxDinner.Enabled = true;
            LabelBreakfastAndDinnerIncl.Visible = false;
        }

        private void RadioButtonDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            _room = new DeluxeRoom(_room);//calls the decorator class of deluxe room
            DisplayPrice();
            CheckBoxBreakfast.Enabled = false;
            CheckBoxDinner.Enabled = false;
            LabelBreakfastAndDinnerIncl.Visible = true;
        }

        private void CheckBoxBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxBreakfast.Checked)
            {
                _room = new AddBreakfast(_room);//decorator
                DisplayPrice();
            }
            else if (CheckBoxBreakfast.Checked == false)
            {
                _room = new RemoveBreakfast(_room);//decorator
                DisplayPrice();
            }
        }

        private void CheckBoxDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxDinner.Checked)
            {
                _room = new AddDinner(_room);//decorator
                DisplayPrice();
            }
            else if (CheckBoxDinner.Checked == false)
            {
                _room = new RemoveDinner(_room);//decorator
                DisplayPrice();
            }
        }

        public void DisplayPrice()
        {
            totalPrice = _room.GetPrice();
            LabelTotalPrice.Text = "€" + totalPrice.ToString(); //displays the price per night
        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {

            if (RadioButtonDeluxe.Checked || RadioButtonStandard.Checked || CheckBoxBreakfast.Checked || CheckBoxDinner.Checked)
            {
                total = LabelTotalPrice.Text;
                CustomerDetails customerDetails = new CustomerDetails();
                customerDetails.Show(); //opens the customer detail form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a package");
            }
        }

        private void RoomBuilder_Load(object sender, EventArgs e)
        {
            RadioButtonStandard.Checked = true; //to ensure users are not able to crash the program
                                                //or get the wrong values we set the
                                                //standard radio button to selected.
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Home.ActiveForm == null)
            {
                Home home = new Home(); 
                home.Show();
            }
        }
    }
}
