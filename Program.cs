﻿using System;

namespace vectores1
{
    class Program
    {
        static void Main()
        {

            //Trabajamos una nueva forma de guardar datos, mediante un vector.
            //podremos guardar mas datos del mismo tipo, en una sola variable (o algo asi)
            //declaramos un vector y lo cargamos con datos mediante un for

            int[] numeros = new int[5];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

         Console.WriteLine("numeros ingresados: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadKey();

        }
    }
}
