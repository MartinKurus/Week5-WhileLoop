using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada pin koodi
            //programm võrdleb sisustatud pin koodi arvuga 1234
            //kui sisestatud pin on 1234
            //programm kuvab konsoolis tere tulemast
            //kui sisestatud pin on vale programm kuvab konsoolis
            //vale pin proovi uuesti
            //katsete arv on piiramatu

            //boolean --> true/false
            bool loopActive = true;
            while(loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale PIN! Proovi uuesti!");
                }
            }

            Console.WriteLine("Kena päeva!");




        }
    }
}
