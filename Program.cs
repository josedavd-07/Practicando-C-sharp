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
            Console.WriteLine($"El resultado de la suma es {resultado}");

          // ___________________________________________________________________


            //llamada a la funcion saludar
            Saludar(Console.ReadLine());

            // ___________________________________________________________________
        }


        //funcion saludar
        static void Saludar( string name)
        {
            Console.WriteLine($"Hola {name}");
        }

        //funcion para sumar numeros enteros 
        static int Suma(int a, int b)
        {
            return a + b;
        }
    }

}