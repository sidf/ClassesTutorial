﻿using System;

namespace ClassesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            //AbstractCar aCar = new AbstractCar();  // can't instantiate an abstract class

            EngineStruct engine = new EngineStruct();

            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();

            Mercedes mercedesEx7 = new Mercedes();
            Console.WriteLine("Mercedes is " + mercedesEx7.Description);
            Console.WriteLine("Mercedes costs " + mercedesEx7.Price);

            var mercedes31 = new Mercedes();
            mercedes31.StartEngine();

            var mercedes32 = new Mercedes();
            mercedes.ShowRemainingNoOfKM(10, 5);

            var mercedes33 = new Mercedes();
            Console.WriteLine(mercedes33.StartEngine());
            Console.WriteLine(mercedes.ShowRemainingNoOfKM(10, 5));

            var mercedes34 = new Mercedes();
            Console.WriteLine(mercedes34.StartEngine(100));

            Console.WriteLine(mercedes34.CalculateConsumption(1, 2, 3, 4, 5, 6));

            Console.WriteLine(FizzBuzz.GetFizzBuzz(15));

            var mercedes3x = new Mercedes();
            mercedes3x.PrintMercedesLogo();

            var m1 = new Mercedes();
            m1.PrintNewMercedes(Mercedes.counter2++);

            var m2 = new Mercedes();
            m2.PrintNewMercedes(Mercedes.counter2++);

            var m3 = new Mercedes();
            m3.PrintNewMercedes(Mercedes.counter2++);

            var m4 = new Mercedes();
            m4.PrintNewMercedes(Mercedes.counter2++);

            Audi a = new Audi();
            Console.WriteLine(a.CarStart());
            Console.WriteLine(a.Vitezometru(2));


            Console.WriteLine("\n");
            Apple a1 = new Apple();
            Orange o1 = new Orange();

            Fruit fr1 = new Apple();
            Fruit fr2 = new Orange();

            Fruit ionatan = new Ionatan();
            Apple ionatan2 = new Ionatan();
            Ionatan ionatan3 = new Ionatan();

            Console.WriteLine(string.Join("\n", ionatan.GetCalories(), ionatan2.GetCalories(), ionatan3.GetCalories()));

            FruitBasket cos = new FruitBasket();
            cos.AddFruit(new Ionatan());
            cos.AddFruit(new Apple());
            cos.AddFruit(new Fruit());
            cos.DisplayFruitCalories();

            Console.WriteLine("This is my first C# project!");
            Console.ReadKey();
        }
    }
}
