using System;

namespace _0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=2; i<n+0; i++)
            {
                int b =  i%2 ;
                if (b%2==0){
                b = (int)Math.Pow(i,2);
                Console.WriteLine(  i+"^2 = "+b  );}          //escreva o seu código nos espaços em branco
                
                
                
            }
        }
    }
}
