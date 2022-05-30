using System;

namespace Desafio_DIO_C__Distância
{
    class Program
    {
        static void Main(string[] args)
        {
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = quilometros * 2;
    
            Console.WriteLine(minutos + " minutos");
        }
    }
}
