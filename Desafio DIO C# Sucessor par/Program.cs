using System;

namespace Desafio_DIO_C__Sucessor_par
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            
                if(x%2==0){
                    int y=x+2;
                    Console.WriteLine(y);
                }else
                {
                    int w=x+1;
                    Console.WriteLine(w);
                }

        }
    }
}
