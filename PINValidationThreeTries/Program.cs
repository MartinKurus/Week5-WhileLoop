using System;

namespace PINValidationThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    //break;
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }
            }
            Console.WriteLine("Kena päeva");
        }
            
    }
}
