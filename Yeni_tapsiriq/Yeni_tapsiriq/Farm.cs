using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_tapsiriq
{
    class Farm
    {

        public Sheep[] Sheeps = new Sheep[0];
        public Cow[] Cows = new Cow[0];
        public Horse[] Horses = new Horse[0];


        public void AddCow(Cow cow)
        {
            Array.Resize(ref Cows, Cows.Length + 1);
            Cows[Cows.Length - 1] = cow;
        }
        public void AddHorse(Horse horse)
        {
            Array.Resize(ref Horses, Horses.Length + 1);
            Horses[Horses.Length - 1] = horse;
        }
        public void AddSheep(Sheep sheep)
        {
            Array.Resize(ref Sheeps, Sheeps.Length + 1);
            Sheeps[Sheeps.Length - 1] = sheep;
        }



    }
}
