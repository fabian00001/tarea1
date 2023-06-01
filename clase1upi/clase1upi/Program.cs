using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1upi
{
    internal class Program
    {
      static  float resultado = 0; // variable global
        static float v1, v2;
        static void Main(string[] args)  // metodo 
        {
            menu();
            Console.ReadKey();
        }

        public static void SolicitarDatos()
        {
            Console.WriteLine("Digite un valor: ");
             v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro valor: ");
             v2 = float.Parse(Console.ReadLine());
        }
        public static void menu()
        {
            resultado = 0;
            int opcion = 0;
            do
            {
                Console.WriteLine("1- suma");
                Console.WriteLine("2- resta");
                Console.WriteLine("3- division");
                Console.WriteLine("4- multiplicacion");
                Console.WriteLine("5- Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:SolicitarDatos();
                          suma(v1, v2); break;
                    case 2:
                        SolicitarDatos();
                        Console.WriteLine("el resultado de la resta es: {0}", resta(v1,v2));
                        break;
                    case 3:
                        SolicitarDatos();
                        division(v1,v2);
                        break;
                    case 4:
                        SolicitarDatos();
                        Console.WriteLine("La mulplicaion es: {0}", multiplicacion(v1, v2));
                        break;
                    case 5: break;


                    default:
                        break;
                }

            } while (opcion != 3);
        }

        public static void division(float valor1, float valor2)
        {
            resultado = 0;
            float total = valor1 / valor2;   // variable locales
            Console.WriteLine($"La division es : {total}");
        }

        public static float multiplicacion(float valor1, float valor2)
        {
            float total = valor1 * valor2;
            return total;
           
        }
        public static void suma(float valor1, float valor2)
        {
            float total = valor1 + valor2;
            int sumar; // variable locales

            Console.WriteLine($"la suma es de: {total}");
        }
        public static float resta(float valor1, float valor2)
        {
            float total = valor1 - valor2;
            return total;
        }
    }
}
