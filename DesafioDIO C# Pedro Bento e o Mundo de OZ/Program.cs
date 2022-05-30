using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioDIO_C__Pedro_Bento_e_o_Mundo_de_OZ
{
    class Program
    {
        static void Main(string[] args)
        {
            string joia = "";
      
      List<string> joias = new List<string>();
      
      do {
        joia = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(joia)) {
          joias.Add(joia);
        } else {
          break;
        }
      }
      
      while (true);
      
      IEnumerable<string> distinctJoias = joias.Distinct();
      
      Console.WriteLine(distinctJoias.Count());
        }
    }
}