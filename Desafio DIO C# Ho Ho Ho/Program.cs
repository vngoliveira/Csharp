﻿using System;

namespace Desafio_DIO_C__Ho_Ho_Ho
{
    class Program
    {
        static void Main(string[] args)
        {
             int N = int.Parse(Console.ReadLine());

            //Exibir "Ho" do papai noel
            for (int i = 0; i < N; i++) {
                if (i<N-1) {
                    Console.Write("Ho ");                  //Complete o código no espaço em branco
                }
                else{
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}
