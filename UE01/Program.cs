using System;

namespace UE01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib 2 Zahlen ein");
            Console.WriteLine();
            
            int zahl1;
            int zahl2;
            
            zahl1= Convert.ToInt32(Console.ReadLine());
            zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Das Ergebnis ist {zahl1 + zahl2}"); 

        }
    }
};

