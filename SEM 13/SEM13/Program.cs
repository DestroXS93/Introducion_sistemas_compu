using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d1, d2, d3, cont;
            cont = 0;
            Random ale_dados = new Random();
            do
            {
                d1 = ale_dados.Next(1, 7);
                d2 = ale_dados.Next(1, 7);
                d3 = ale_dados.Next(1, 7);
                cont++; //cont=cont+1
                Console.Write("Dado 1: " + d1);
                Console.Write(" Dado 2: " + d2);
                Console.WriteLine(" Dado 3: " + d3);
            } while (d1 != 6 || d2 != 6 || d3 != 6);
            Console.WriteLine("EL numero de lanzamientos: " + cont);
        }
    }
}
