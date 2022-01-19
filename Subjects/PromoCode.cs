using HotelBookingDemo.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo
{
    //In this class, observers are added to a list of observers,
    //before the list of observers are notified of
    //any new promotional code created in AdminPromoDeals.cs

    public class PromoCode : ISubject

    {
        public static List<IObserver> _observers; //declaring the list
        public string _promoCode;

        public string PromotionCode
        {
            get { return _promoCode; }
            set
            {
                _promoCode = value;
                NotifyObservers();
            }
        }

        public PromoCode()
        {
            _observers = new List<IObserver>(); //initialising the list
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);

        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers?.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);     //updating the observers using the IObserver interface
            });
        }
    }
}

