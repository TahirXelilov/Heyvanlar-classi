using System;

namespace Yeni_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Animal animal = new Animal("Inek",11,22,4);

            //Console.WriteLine(animal);
            //var result = Animal.Showinfo();
            //Console.WriteLine(result);
            Animal animal = new Animal("Qoyun", 3, 90, 4);
            var result1 = animal.Showinfo();
            Console.WriteLine(result1);


            Cow cow = new Cow(10, "QaraBula", 3, 500, 4);
            var result2 = cow.Showinfo();
            Console.WriteLine(result2);


            Sheep sheep = new Sheep("Qara",2,99,4);
            //Console.WriteLine(sheep);
            var result3 = sheep.Showinfo();
            Console.WriteLine(result3);

            //Farm farm = new Farm();
            //var result3 = cow.Showinfo();
            //Console.WriteLine(result3);

            Horse horse = new Horse(65, "Qirat", 3, 400, 4);
            var result4 = horse.Showinfo();
            Console.WriteLine(result4);






        }
    }
}
