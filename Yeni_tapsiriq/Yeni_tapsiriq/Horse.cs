using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_tapsiriq
{
    class Horse:Animal
    {
        public float RunSpeed;
        public Horse(float runspeed, string name, int age, int weight, int footcount) :base(name, age, weight,footcount)
        {
            RunSpeed = runspeed;
        }
        public override string Showinfo()
        {
            return base.Showinfo() + $", Atin sureti : {RunSpeed} ";
        }
    }
}
