using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sueldo;
            int cont = 0;      // Contador general
            int contMay = 0;   // Contador de sueldos mayores a 3000
            int contMenor = 0; // Contador de sueldos menores o iguales a 3000
            int suma = 0;      // Acumulador de sueldos

            Random ale_sueldos = new Random();

            do
            {
                sueldo = ale_sueldos.Next(2500, 3501);
                Console.WriteLine("Sueldo Generado: " + sueldo);

                cont++;
                suma += sueldo; // suma = suma + sueldo

                if (sueldo > 3000)
                {
                    contMay++;
                }
                else
                {
                    contMenor++;
                }
            }
            while (sueldo != 2500); // Condición completada (puedes modificarla si el corte era otro)
        }
    }
}
