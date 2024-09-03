using System;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Instrukcje podejmowania decyzji");

            int a = 10;

            if (a < 20)
            {
                Console.WriteLine("a jest mniejsze od 20");
            }
            else
            {
                Console.WriteLine("a jest większe od 20");


            }
            int b = 3;

            if (b == 3)
            {
                Console.WriteLine("b wynosi 3");
            }


            Console.WriteLine("Menu: ");
            Console.WriteLine("Równanie 1: x^2");
            Console.WriteLine("Równanie 2: x^3");
            Console.WriteLine("Równanie 3: x^4");
            string op = Console.ReadLine();  


            switch (op)
            {


                case "x^2":
                    Console.WriteLine("Wybrano równanie 1");

                    break;

                case "x^3":
                    Console.WriteLine("Wybrano równanie 2");

                    break;

                case "x^4":
                    Console.WriteLine("Wybrano równanie 3");

                    break;

            }


                
            
        }



    }
}