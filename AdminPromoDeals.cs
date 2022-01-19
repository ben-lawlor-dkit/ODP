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
    public partial class AdminPromoDeals : Form
    {
        public static string promodeal = "";

        public AdminPromoDeals()
        {
            InitializeComponent();

        }
        private void AdminPromoDeals_Load(object sender, EventArgs e)
        {
            if (!CustomerList.customers_list.Any())
            {
                LabelWarning.Visible = true;
            }
        }

        private void ButtonPromoDeals_Click(object sender, EventArgs e)
        {
            SendPromo();
            LabelPromotionalDeal.Text = "Offer ''" + promodeal.ToUpper() + "'' sent!" ;
            LabelPromotionalDeal.Visible = true;
        }

        public void SendPromo()
        {

            PromoCode promoCode = new PromoCode();
            foreach (Customer c in CustomerList.customers_list)
            {
                //Registering all customers from CustomerList.cs as observers.
                Customer registeredCustomer = new Customer(c.Name, c.Surname, c.Address, c.Email, c.Phone, c.NightsBooked);
                promoCode.RegisterObserver(registeredCustomer);
            }

            promoCode.PromotionCode = richTextBoxPromoDeals.Text; //When this value is updated, observers are notified
            promodeal = promoCode.PromotionCode; //This static string is used to pass the promotion to the main form,
                                                 //where it is added to a label.

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
