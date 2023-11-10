using System;

String nombre;
int años;


Console.Write("Escribe tu nombre: ");
nombre = Console.ReadLine();
Console.WriteLine($"Tu nombre es {nombre} ");

Console.Write("Cuantos años tienes?: ");
años = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hola {nombre} veo que tienes {años} años, bienvenido al grupo");