// Zurückgreifen auf Rechner aus Assignment 1
using System;
using System.Collections.Generic;
using Assignment1;

namespace Assignment4
{
    class Program
    // Beginn des Programms 
    {
        static void Main(string[] args)
        {
            var rechner = new Rechner();
            var history = new List<string>(); // Liste vergangener Rechnungen
            bool running = true;
            while (running)
                {
                // 
                Console.WriteLine("\n=== Scientific Calculator ===");
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Basic Operations (+, -, *, /, %)");
                Console.WriteLine("2. Square Root");
                Console.WriteLine("3. Power (x^y)");
                Console.WriteLine("4. View History");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option (1–5): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": // Grundrechenarten
                        
                        Console.WriteLine("Gib die erste Zahl ein:");
                        double Zahl1;
                        while (!double.TryParse(Console.ReadLine(), out Zahl1))
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Zahl eingeben:");
                        }
                        Console.WriteLine("Gib die gewünschte Operation ein: + , - , * , / , %");
                        string op = Console.ReadLine();
                        
                        Console.WriteLine("Gib eine weitere Zahl ein:");
                        double Zahl2;
                        while (!double.TryParse(Console.ReadLine(), out Zahl2))
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Zahl eingeben:");
                        }

                        double ergebnis = 0;

                        switch (op)
                        {
                            case "+":
                                case "-":
                                ergebnis = rechner.Berechne(Zahl1, Zahl2, op);
                                break;
                            case "/":
                                if (Zahl2 == 0)
                                {
                                    Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt!");
                                    ergebnis = Double.NaN;
                                    }
                                else 
                                ergebnis = Zahl1 / Zahl2;
                                break;
                            case "%":
                                ergebnis = Zahl1 % Zahl2;
                                break;
                            default:
                                Console.WriteLine("Ungültige Operation!");
                                ergebnis = Double.NaN;
                                break;
                        }
                        Console.WriteLine(($"Ergebnis: {Zahl1} {op} {Zahl2} = {ergebnis}"));
                        history.Add($"{Zahl1} {op} {Zahl2} = {ergebnis}");
                        break;
                    
                    case "2": // Wurzel
                        Console.WriteLine("Gib eine Zahl ein:");
                        double num =  Convert.ToDouble(Console.ReadLine());
                        double wurzel = Math.Sqrt(num);
                        Console.WriteLine($" Ergebnis: √{num} = {wurzel}");
                        history.Add($"{num} = {wurzel}");
                        break;
                    case "3": // Potenzieren
                        Console.WriteLine("Gib die Basis ein:");
                        double basis = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Gib den Exponenten ein:");
                        double exponent = Convert.ToDouble(Console.ReadLine());
                        double potenz = Math.Pow(basis, exponent);
                        Console.WriteLine($"Ergebnis: {basis}^{exponent} = {potenz}");
                        history.Add($"{basis}^{exponent} = {potenz}");
                        break;
                    
                    case "4": // Verlauf anzeigen
                        Console.WriteLine("\n=== Letzte 5 Berechnungen ===");
                        if (history.Count == 0)
                        {
                            Console.WriteLine("Keine Berechnungen vorhanden.");
                        }
                        else
                        {
                            int start = Math.Max(0, history.Count - 5);
                            for (int i = start; i < history.Count; i++)
                                Console.WriteLine(history[i]);
                        }
                        break;

                    case "5": // Beenden
                        running = false;
                        Console.WriteLine("Danke, dass du den Scientific Calculator benutzt hast! :)");
                        break;

                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte 1–5 eingeben.");
                        break;
                }

                
                
                
        }
    }}}
