using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Capitulo4
    {
        public Capitulo4()
        {

        }

        public void Ejercicio1()// Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.
        {
            Console.Clear();
            Console.WriteLine("Digite el numero de la tabla que desea mostrar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int acum;
            for(int i=1;i<=10;++i)
            {
                acum = numero * i;
                Console.WriteLine("{0} * {1} = {2}", numero, i, acum);
            }
        }

        public void Ejercicio2()// Hacer un programa que calcule el resultado de un número elevado a cualquier potencia.
        {
            Console.Clear();
            Console.WriteLine("Digite la base: ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite La potencia: ");
            int potencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} ^ {1} = {2:N0}", bas, potencia, (int)Math.Pow(bas, potencia));
        }
        public void Ejercicio3()/*Hacer un programa que calcule el promedio de edad de un grupo de personas 
                                  y diga cuál es la de edad más grande y cuál es la más joven.*/
        {
            Console.Clear();
            Console.WriteLine("Digite la cantidad de personas que contiene el grupo");
            int cantidadDePersonas = Convert.ToInt32(Console.ReadLine());
            int edadMayor=0;
            int edadMenor=9999;
            int edad;
            for(int i=1;i<=cantidadDePersonas;i++)
            {
                Console.WriteLine("Edad de Persona: {0}", i);
                edad = Convert.ToInt32(Console.ReadLine());
                if (edadMayor < edad)
                    edadMayor = edad;
                if (edadMenor > edad)
                    edadMenor = edad;
            }

            Console.WriteLine("Mayor es: {0}", edadMayor);
            Console.WriteLine("Menor es: {0}", edadMenor);
        }
    }
}
