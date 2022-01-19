using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo.Subjects.Decorator
{
    class RoomDecorator : IRoom
    {
        protected readonly IRoom _room;

        public RoomDecorator(IRoom room)
        {
            _room = room;
        }

        public virtual double GetPrice()
        {
            return _room.GetPrice();
        }

        public virtual string GetInfo()
        {
            return _room.GetInfo();
        }
    }
}
