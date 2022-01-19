using HotelBookingDemo.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo.Subjects
{
    //This is the base interface for decorator implementation    
    public interface IRoom
    {
        double GetPrice();
        string GetInfo();
    }
}


