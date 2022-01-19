using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo.Subjects
{
    public interface ISubject
    {
        void RegisterObserver(IObserver Observer);//using interface to register, unregister, and notify observers
        void UnregisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
