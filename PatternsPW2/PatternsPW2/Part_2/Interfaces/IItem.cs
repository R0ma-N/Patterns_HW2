using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPW2.Part_2
{
    interface IItem
    {
        void SetPrice(double price) { ;}
        void SetDiscount(double discount) { ;}
        void SetPromocode(string promocode) { ;}
    }
}
