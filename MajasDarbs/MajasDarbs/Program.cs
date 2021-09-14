using System;

namespace MajasDarbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //------------------------------------------
            Console.WriteLine("Hi!");

            Console.WriteLine("Kā tevi sauc?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName);

            Console.WriteLine("ļoti patīkami iepazītes!");

            Console.WriteLine("Kur tu dzīvo?");

            string userName1 = Console.ReadLine();

            Console.WriteLine("Skaidrs!");

            Console.WriteLine("Cik tev ir gadi?");

            string ageText = Console.ReadLine();
            int age = int.Parse(ageText);
            int previosYearAge = age - 1;

            Console.WriteLine("Sveiks tev ieprekšēja gadā bija:  " + previosYearAge);


            Console.WriteLine("Prieks iepazītes!");

            Console.WriteLine();



            //--------------------------------------


        }
    }

{
