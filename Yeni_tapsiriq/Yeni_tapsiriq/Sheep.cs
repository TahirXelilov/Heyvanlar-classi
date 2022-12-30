using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_tapsiriq
{
    class Sheep: Animal
    {
       
        public Sheep( string name, int age, int weight, int footcount) : base(name, age, weight, footcount)
        {
            //Console.WriteLine("Sheep dolduruldu");
        }

        public override string Showinfo()
        {
            return base.Showinfo();
        }
        //public override string FullInfo()
        //{
        //    StringBuilder str = new StringBuilder();
        //    str.Append(" Genres: ");
        //    foreach (var item in Sheep)
        //    {
        //        str.Append(item);
        //        str.Append(" ");
        //    }
        //    return base.FullInfo() + str;
        //}



    }
}
