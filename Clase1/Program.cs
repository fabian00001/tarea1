using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char Opcion = 's';
            do
            {
                int num1;
                int num2;
                int suma;
                int resta;
                int multi;
                int div;


                
                Console.WriteLine("1- Sumar");
                Console.WriteLine("2- Restar");
                Console.WriteLine("3- Dividir");
                Console.WriteLine("4- Multiplicar");
                Console.WriteLine("5 salir del menu");
                Opcion = char.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case '1':
                        Console.WriteLine("ingrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        suma = num1 + num2;
                        Console.WriteLine(num1+ " + " + num2 + " = " + suma);
                        break;
                    case '2':

                        Console.WriteLine("ingrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        resta = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + resta);
                        break;
                    case '3':
                        Console.WriteLine("ingrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        multi = num1 * num2;
                        Console.WriteLine(num1 + " x " + num2 + " = " + multi);
                        break;
                    case '4':
                        Console.WriteLine("ingrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        div = num1 / num2;
                        Console.WriteLine(num1 + " ÷ " + num2 + " = " + div);
                        break;
                    case '5':
                        Console.WriteLine("Ha salido del menu"); break;
                        
                    default: Console.WriteLine("opcion incorrecta"); break;

                }

            } while (!Opcion.Equals('5'));

            Console.ReadLine();




        }
    }

}

