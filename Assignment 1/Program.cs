// See https://aka.ms/new-console-template for more information

namespace Assignment1
{
public class Rechner

    {
static void Main(string[] args)

{Console.WriteLine("Gib eine Zahl ein");
    double Zahl1 = Convert.ToDouble(Console.ReadLine());
    
Console.WriteLine("Gib eine weitere Zahl ein");
double Zahl2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Gib die gewünschte Operation ein: + , - , / , *");
string op = Console.ReadLine();
Console.WriteLine();
double ergebnis = 0;



if (op == "+")
{
    ergebnis = Zahl1 + Zahl2;
}
else if (op == "-")
{
    ergebnis = Zahl1 - Zahl2;}
else if (op == "*")
{
    ergebnis = Zahl1 * Zahl2;}
else if (op == "/")
{
    ergebnis = Zahl1 / Zahl2;}
else
{
    Console.WriteLine("Ungültige Werte eingegeben");
}
Console.WriteLine("Das Ergebnis ist: " + ergebnis);

}

public double Berechne(double Zahl1, double Zahl2, string op)
{
    double ergebnis = 0;
    if (op == "+")
        ergebnis = Zahl1 + Zahl2;
    else if (op == "-")
        ergebnis = Zahl1 - Zahl2;
    else if (op == "*")
        ergebnis = Zahl1 * Zahl2;
    else if (op == "/")
        ergebnis = Zahl1 / Zahl2;
    else
        ergebnis = double.NaN;

    return ergebnis;
}

}}