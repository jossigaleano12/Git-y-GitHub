using System;
class Programa
{
    static void Main()
    {
        Console.Write("¿Cuál es tu nombre? ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}!");
    }
}