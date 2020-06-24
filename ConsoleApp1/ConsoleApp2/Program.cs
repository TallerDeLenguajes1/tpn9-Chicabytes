using System;
using Helpers;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el texto a traducir, en castellano: ");
            string Texto_a_Traducir = Console.ReadLine();
            string Traduccion = ConversorDeMorse.TextoAMorse(Texto_a_Traducir);
            Console.WriteLine("El texto traducido es: " + Traduccion);
            ConversorDeMorse.GuardarArchivo(Traduccion);
            Console.WriteLine("El texto reconvertido es: " + ConversorDeMorse.LeerArchivo());
        }
    }
}
