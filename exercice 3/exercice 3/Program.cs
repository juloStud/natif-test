using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Entrez un nombre: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            string output = (number % 2 == 0) ? "pair" : "impair";
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre entier valide.");
        }
    }
}