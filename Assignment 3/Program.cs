using System;
using System.Collections.Generic;
using Assignment1;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rechner = new Rechner();
            var history = new List<string>();
            bool weitermachen = true;
            while (weitermachen)
                {
                Console.WriteLine("Wilkommen. Gib eine Zahl ein:");
                double Zahl1 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Gib die gewünschte Operation ein: + , - , * , / , % , ^ , √ :");
                string op = Console.ReadLine();

                double Zahl2 = 0; 
                
                if (op != "√")
                {
                    Console.WriteLine("Gib eine weitere Zahl ein:");
                    Zahl2 = Convert.ToDouble(Console.ReadLine());
                }
                
                Console.WriteLine();
                double ergebnis;

                switch (op)
                {
                    case "+":
                        case "-":
                        case "*":
                        ergebnis = rechner.Berechne (Zahl1, Zahl2, op);
                        break;
                    
                    case "/":
                        if (Zahl2 == 0)
                        {
                            Console.WriteLine("Fehler: Division durch 0 nicht erlaubt!");
                            ergebnis =  Double.NaN;
                        }
                        else
                        ergebnis =  Zahl1 / Zahl2;
                        break;
                    case "%":
                        if (Zahl2 == 0)
                        {
                            Console.WriteLine("Fehler: Division durch 0 nicht erlaubt!");
                            ergebnis = Double.NaN;
                        }
                        else
                        ergebnis = Zahl1 % Zahl2;
                        break;
                    case "^":
                        ergebnis = Math.Pow(Zahl1, Zahl2);
                        break;
                    case "√":
                        ergebnis = Math.Sqrt(Zahl1);
                        break;
                    default:
                        Console.WriteLine("Ungültige Operation!");
                        ergebnis = Double.NaN;
                        break;
                }
                Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
                
                if (op == "√")
                { history.Add($"√{Zahl1} = {ergebnis}");}
                else
                {
                    history.Add($"{Zahl1} {op} = {ergebnis}");
                
                Console.WriteLine("Willst du eine weitere Rechnung durchführem? (j/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "j") weitermachen = false;
                
                }
            Console.WriteLine("\nLetzten 5 durchgeführten Berechnungen:");
            int start = Math.Max(0, history.Count - 5);
            for (int i = start; i < history.Count; i++)

            {
                Console.WriteLine(history[i]);
            }
                }
            
            Console.WriteLine("Danke, dass du diesen Rechner benutzt hast! :)");
            
            
                
            }
        }
    }
