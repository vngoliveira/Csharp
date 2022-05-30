using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
                   int limit = Int32.Parse(Console.ReadLine());
    for (int i = 0; i < limit; i++) 
    {
      string[] line = Console.ReadLine().Split(" ");
      double X = double.Parse(line[0]);
      double Y = double.Parse(line[1]);
      if ( Y != 0 )
        {
          double resultado=X/Y;
          if((resultado==0) && (resultado==0.9))
          {
            Console.WriteLine("0.0");
          }
          else
          {
          //Math.Round(resultado,2);
          //resultado.double = String.Format( "{0:#.#,#}", resultado);
          Console.WriteLine(resultado.ToString("#0.0"));
            
          }
        }
        else
        {
          Console.WriteLine("divisao impossivel"); 
        }
        }
        }
    }
}
