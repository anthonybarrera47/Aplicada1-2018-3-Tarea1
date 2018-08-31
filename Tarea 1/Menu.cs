using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Menu
    {
        public Menu()
        {

        }
        public void ImprimirMenu()
        {
            SubMenu();
            Capitulo1 cap1 = new Capitulo1();
            Capitulo2 cap2 = new Capitulo2();
            Capitulo3 cap3 = new Capitulo3();
            Capitulo4 cap4 = new Capitulo4();
                
                int opcion = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                
                switch (opcion)
                {
                    case 1:
                        cap1.Ejercicio1();
                        break;
                    case 2:
                        cap1.Ejercicio5();
                        break;
                    case 3:
                        cap2.Ejercicio1();
                        break;
                    case 4:
                        cap2.Ejercicio3();
                        break;
                    case 5:
                        cap2.Ejercicio4();
                        break;
                    case 6:
                        Console.Clear();
                        int opc;
                        Console.WriteLine("Dolares a Euros");
                        Console.WriteLine("Euros a Dolares");
                        opc = Convert.ToInt32(Console.ReadLine());
                        switch (opc)
                        {
                            case 1:
                                cap2.Ejercicio5_1();
                                break;
                            case 2:
                                cap2.Ejercicio5_2();
                                break;
                        }
                        break;          
                    case 7:
                        Console.WriteLine(cap3.Ejercicio1());
                        break;
                    case 8:
                        Console.WriteLine(cap3.Ejercicio4());
                        break;
                    case 9:
                        cap3.Ejercicio5();
                        break;
                    case 10:
                        cap4.Ejercicio1();
                        break;
                    case 11:
                        cap4.Ejercicio2();
                        break;
                    case 12:
                        cap4.Ejercicio3();
                        break;
                    case 13:
                        Console.WriteLine("Gracias Por Utilizar Este Programa :)");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    }
                Console.ReadKey();
                ImprimirMenu();
            }


        }

        public void SubMenu()
        {
            Console.Clear();
            Console.WriteLine("Capitulo 1");
            Console.WriteLine("\t1.Ejercicio 1 (Cree un proyecto nuevo que imprima su nombre en la ventana de la consola.)");
            Console.WriteLine("\t2.Ejercicio 5 (Agregue más mensajes a la aplicación que ha creado)");
            Console.WriteLine("Capitulo 2");
            Console.WriteLine("\t3.Ejercicio 1 (Hacer un programa que calcule el perímetro de cualquier polígono regular.)");
            Console.WriteLine("\t4.Ejercicio 3 (Hacer un programa que transforme de grados a radianes)");
            Console.WriteLine("\t5.Ejercicio 4 (Hacer un programa que transforme de grados centígrados a grados Fahrenheit.)");
            Console.WriteLine("\t6.Ejercicio 5 (Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.)");
            Console.WriteLine("Capitulo 3");
            Console.WriteLine("\t7.Ejercicio 1 (Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar.)");
            Console.WriteLine("\t8.Ejercicio 4 (Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana)");
            Console.WriteLine("\t9.Ejercicio 5 (Hacer una programa que pueda calcular el perímetro y el área de cualquier polígono regular, pero que le pregunte al usuario qué desea calcular)");
            Console.WriteLine("Capitulo 4");
            Console.WriteLine("\t10.Ejercicio 1 (Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.)");
            Console.WriteLine("\t11.Ejercicio 2 (Hacer un programa que calcule el resultado de un número elevado a cualquier potencia.)");
            Console.WriteLine("\t12.Ejercicio 5 (Hacer un programa que calcule el promedio de edad de un grupo de personas y diga cuál es la de edad más grande y cuál es la más joven)");
            Console.WriteLine("\n\n\n13.Salir");
        }
    }
        
}

