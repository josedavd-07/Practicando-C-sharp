using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace programando_en_remoto
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamada a la funcion suma

            int resultado = Suma(2, 3);
            //Damos color verte  al resultado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El resultado de la suma es {resultado}");

          // ___________________________________________________________________


            //llamada a la funcion saludar
            Saludar(Console.ReadLine());

            // ___________________________________________________________________
            
            Console.ReadKey();
        }


        //funcion saludar
        static void Saludar( string name)
        {
            //Damos color rojo al saludo
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hola {name}");
        }

        //funcion para sumar numeros enteros 
        static int Suma(int a, int b)
        {
            return a + b;
        }
    }

}