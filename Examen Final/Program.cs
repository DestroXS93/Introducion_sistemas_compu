using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double recaudado = 0;
            int Pro = 0;
            int valorant= 0;
            Console.WriteLine("===========================================");
            Console.WriteLine("SISTEMA DE INSCRIPCIÓN - CYBERARENA ESPORTS");
            Console.WriteLine("===========================================");
            Console.WriteLine("¿Cuántos jugadores se van a registrar hoy?:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Registrando nombre del jugador;N°:" + i + "----");
                int edad = rnd.Next(12, 45);
                Console.WriteLine("Ingrese la edad del jugador:" + edad);
                int pntje = rnd.Next(100, 1001);
                Console.WriteLine("Ingrese el puntaje en clasificatoria:" + pntje);
                int juego = rnd.Next(1, 6);
                Console.WriteLine("Ingrese el juego en el que desea participar (1. Valorant,2. LoL, 3. FC 2026, 4. Fornite, 5 otro):");

                if (edad < 18)
                {
                    Console.WriteLine(" -> [AVISO] Jugador en categoría Junior: Requiere autorización firmada. ");
                    recaudado += 100;
                }
                string rango;
                if (pntje >= 500)
                {
                    rango = "Jugador Pro (Con Bono)";
                    Pro++;
                }

                else
                {
                    rango = "Jugador Amateur";
                }
                double costo = 0;
                switch (juego)
                {
                    case 1:
                        costo = 25;
                        valorant++;
                        break;
                    case 2:
                        costo = 200;
                        break;
                    case 3:
                        costo = 30;
                        break;
                    case 4:
                        costo = 15;
                        break;
                    case 5:
                        costo = 10;
                        break;
                }
                
            recaudado += costo;
            Console.WriteLine("[Ficha] Rango:"+ rango+"|tarifa a pagar: $" +costo.ToString("0.00"));
            Console.WriteLine("==================================================");
            Console.WriteLine("              REPORTE FINANCIERO Y ESTADÍSTICO    ");
            Console.WriteLine("==================================================");
            Console.WriteLine("Gran Total Recaudado en Caja : $ " + recaudado.ToString("0.00"));
            Console.WriteLine(" Total de Jugadores 'Pro'    : " + Pro +"competidores");
            Console.WriteLine("Total Inscritos en Valorant  : " + valorant ,"Jugadores" );
            Console.WriteLine("==================================================");

            }
        }
    }
}
