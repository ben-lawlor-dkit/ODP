using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingDemo.Subjects.Decorator
{
    class RemoveBreakfast : RoomDecorator
    {
        public RemoveBreakfast(IRoom room) : base(room)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() - 15.99;
        }

        public override string GetInfo()
        {
            string removeBreakfast = base.GetInfo().Replace(", breakfast", "");
            return removeBreakfast;
        }
    }
}
