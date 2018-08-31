using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Capitulo3
    {
        public Capitulo3()
        {

        }
        public String Ejercicio1()// Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar.
        {
            Console.Clear();
            Console.WriteLine("Introduzca un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
                return "Es par";
            else
                return "Es Inpar";
        }

        public String Ejercicio4()//Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana.
        {
            Console.Clear();
            Console.WriteLine("Numero de semana: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    return "Domingo";                  
                case 2:
                    return "Lunes";                    
                case 3:
                    return "Martes";                  
                case 4:
                    return "Miercoles";                 
                case 5:
                    return "Jueves";                  
                case 6:
                    return "Viernes";                  
                case 7:
                    return "Sabado";
                default:
                    return " ";
            }
        }
        public void Ejercicio5()//Hacer una programa que pueda calcular el perímetro y el área de cualquier polígono regular, pero que le pregunte al usuario qué desea calcular
        {
            Console.Clear();
            int opc;
            float perimetro = 0;
            Console.WriteLine("1. Calcular Perimetro");
            Console.WriteLine("2. Calcular Area");
            Console.WriteLine("Elija lo que desea calcular");
            opc = Convert.ToInt32(Console.ReadLine());
            switch(opc)
            {
                case 1:
                    Console.Clear();
                    float longitudLado;
                    int numeroLado;
                    Console.WriteLine("Digite la longitud del lado: ");
                    longitudLado = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite la cantidad del lado: ");
                    numeroLado = Convert.ToInt32(Console.ReadLine());
                    perimetro = longitudLado * numeroLado;
                    Console.WriteLine("El perimetro es: {0}", perimetro);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Digite el Perimetro: ");
                    perimetro = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite el Apotema: ");
                    float apotema = Convert.ToSingle(Console.ReadLine());
                    float area = apotema * perimetro;
                    Console.WriteLine("El Area del poligono es: {0}", area);
                    break;
            }
        }
    }
}
