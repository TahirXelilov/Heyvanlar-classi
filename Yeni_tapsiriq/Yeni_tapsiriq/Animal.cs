using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_tapsiriq
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int FootCount { get; set; }

        public Animal(string name, int age,int weight, int footcount)
        {
            Name = name;
            Age = age;
            Weight = weight;
            FootCount = footcount;
        }
        public virtual string Showinfo()
        {
            
            return $"Heyvanin Adi: {Name}, Yasi: {Age}, Cekisi: {Weight}, AyaqSayi:{FootCount} ";

        }

    }
}
