using System;
using Assignment1;

namespace Assignment2
{

class Program2
{
    static void Main (string[] args)

    {var Rechner = new Rechner();
        bool weitermachen = true;
        while (weitermachen)
        {
        Console.WriteLine("Gib eine Zahl ein");
    double Zahl1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Gib eine weitere Zahl ein");
    double Zahl2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Gib die gewünschte Operation ein: + , - , / , * , %");
    string op = Console.ReadLine();
    Console.WriteLine();
    double ergebnis = 0;
    ergebnis = Rechner.Berechne(Zahl1, Zahl2,op);
    switch (op)
    {
        case "+":   
            case "-":
            case "/":
            case "*":
            
            ergebnis = Rechner.Berechne(Zahl1, Zahl2, op);
            break;
        case "%":
            ergebnis = Zahl1 % Zahl2;
            break;
            if (Zahl2 == 0)
            {
                Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt!");
                ergebnis = Double.NaN;
            }
            else
            {
                ergebnis = Zahl1 % Zahl2;
            }
        default:
                Console.WriteLine("Ungültige Eingabe");
                ergebnis = double.NaN;
                break;
    }
    
    Console.WriteLine($"Das Ergebnis: {ergebnis}");
    Console.WriteLine();
    
    Console.WriteLine("Willst du eine weitere Rechnung durchführen? (j/n)");
    string antwort = Console.ReadLine();
    if (antwort.ToLower() != "j")
    {
        weitermachen = false;
    }
    }
    
      Console.WriteLine("Danke, dass du diesen Rechner benutzt hast! :) ");
      
    
    }}}