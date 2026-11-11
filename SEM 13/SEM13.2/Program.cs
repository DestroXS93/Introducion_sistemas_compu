using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM13._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, numero;
            int suma = 0;
            Random ale_numero = new Random();

            do
            {
                numero = ale_numero.Next(10, 91);
                suma += numero;
                Console.WriteLine("Numero: " + numero);
                if (numero >= 10 && numero <= 30) cont1++;
                else if (numero >= 31 && numero <= 50) cont2++;
                else if (numero >= 51 && numero <= 70) cont3++;
                else cont4++;
                cont++;
            } while (numero % 2 != 0 || numero <= 45 || numero >= 55);
            //obtener un número par mayor de 45 pero menor de 55. 
            Console.WriteLine("La cantidad de números generados." + cont);
            Console.WriteLine("La suma de todos los números generados:" + suma);
            Console.WriteLine("La cantidad de números generados del intervalo 10 a 30:" + cont1);
            Console.WriteLine("La cantidad de números generados del intervalo 31 a 50:" + cont2);
            Console.WriteLine("La cantidad de números generados del intervalo 51 a 70:" + cont3);
            Console.WriteLine("La cantidad de números generados del intervalo 71 a 90:" + cont4);
        }
    }
}
