using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_tapsiriq
{
    class Cow:Animal
    {
        public double DailyMilk;
        public Cow(double dailymilk, string name, int age, int weight, int footcount) : base(name, age, weight, footcount)
        {
            DailyMilk = dailymilk;
        }
        public override string Showinfo()
        {
            return base.Showinfo() + $", Gundelik sud miqdari : {DailyMilk} ";
        }
    }
}
