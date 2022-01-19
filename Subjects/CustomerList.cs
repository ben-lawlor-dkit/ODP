using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo
{
    public class CustomerList

    {
        public static List<Customer> customers_list = new List<Customer>();

        public CustomerList()
        {
        }

        public static void AddCustomerToList(Customer customer)
        {
            customers_list.Add(customer);
        }
    }

    
}
