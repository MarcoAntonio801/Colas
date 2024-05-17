using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamañoDatos;
            string persona;
            bool v = true;
            Queue miFila = new Queue(); //crear una nueva cola

           

            Console.WriteLine();

            do
            {
                Console.Write("ingrese el nùmero de personas a ingresar:");
                tamañoDatos = int.Parse(Console.ReadLine());
                if (tamañoDatos < 100)
                {
                    for (int i = 0; i < tamañoDatos; i++)
                    {
                        Console.Write("ingrese la persona " + (i + 1) + ":");
                        persona = Console.ReadLine();
                        miFila.Enqueue(persona);
                    }
                    v = false;

                }
                else
                {
                    Console.WriteLine("Número máximo superado (99)");

                }


            } while (v == true);




                Console.WriteLine();

            //miFila.Enqueue("El chavo"); // cargamos el dato del inicio de la cola
            //miFila.Enqueue("La chilindrina");
            //miFila.Enqueue("El kiko");
            //miFila.Enqueue("El Ñoño");




            for (int cont = 0;cont  < tamañoDatos ;cont++) // para recorrer las filas
            {
                Console.WriteLine("La cajera atendera a: " + miFila.Dequeue());//imprime los datos de la cola
            }

            Console.ReadKey();
        }
    }
}
