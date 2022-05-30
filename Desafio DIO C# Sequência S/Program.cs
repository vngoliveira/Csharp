using System;

namespace Desafio_DIO_C__Sequência_S
{
    class Program
    {
        static void Main(string[] args)
        {
          double a, c, S= 0;
            for (  a  =  1 ; a  <=  100 ; a ++     )
            {
                c =    1/a       ;  //coloque a sua lógica nos espaços em branco
                S +=  c      ;
            }
           
            var x=Math.Round(S, 2);
            Console.WriteLine(   x   );
        }
        
    }
}
