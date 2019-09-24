using System;
using System.Collections.Generic;
using System.Text;

namespace A._Watermelon
{
    public class Watermelon:Fruit
    {
        int watermelonWeight = 0;
        public Watermelon(int watermelonWeight)
        {
            this.watermelonWeight = watermelonWeight;
        }

        public override string IsDivideTwoPart()
        {
            return (watermelonWeight % 2 == 0 && watermelonWeight > 2) ? "YES" : "NO";
        }
    }
}
