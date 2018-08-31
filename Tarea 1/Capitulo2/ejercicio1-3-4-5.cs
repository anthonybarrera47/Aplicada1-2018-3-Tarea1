using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Capitulo2
    {
        Menu m = new Menu();
        public Capitulo2()
        {

        }
        public void Ejercicio1()// Hacer un programa que calcule el perímetro de cualquier polígono regular.
        {
            Console.Clear();
            float perimetro = 0;
            float longitudLado;
            int numeroLado;
            Console.WriteLine("Digite la longitud del lado: ");
            longitudLado = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite la cantidad del lado: ");
            numeroLado = Convert.ToInt32(Console.ReadLine());
            perimetro = longitudLado * numeroLado;
            Console.WriteLine("El perimetro es: {0}", perimetro);
        }
        public void Ejercicio3()//Hacer un programa que transforme de grados a radianes
        {
            Console.Clear();
            float  grados, numRadianes;
            Console.WriteLine("Digite la cantidad de grados que desea convertir:");
            grados = Convert.ToSingle(Console.ReadLine());
            numRadianes = grados * ((float)Math.PI / 180);
            Console.WriteLine("El numero de Radianes es: {0}", numRadianes);
            
        }
        public void Ejercicio4()//Hacer un programa que transforme de grados centígrados a grados Fahrenheit.
        {
            Console.Clear();
            float tempC;
            Console.WriteLine("Convertir de Grado C a grado F");
            Console.WriteLine("Ingrese la temperatura Celsius");
            tempC = Convert.ToSingle(Console.ReadLine());
            tempC = (tempC * 1.8f) + 32;
            Console.WriteLine("La temperatura en grado Farenheit es: {0}", tempC);

        }
        public void Ejercicio5_1()// Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.
        {
            Console.Clear();
            float dolares;
            const float tasaEuro = 0.86f;
            float cambio = 0;
            Console.WriteLine("Digite la cantidad de Dolares que desea convertir a Euros");
            dolares = Convert.ToSingle(Console.ReadLine());
            cambio = dolares * tasaEuro;
            Console.WriteLine("La conversion es igual a: {0}", cambio);
            Console.ReadKey();
            
        }
        public void Ejercicio5_2()// Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.
        {
            Console.Clear();
            float euros;
            const float tasaDolar = 1.16f;
            float cambio = 0;
            Console.WriteLine("Digite la cantidad de Euros que desea convertir a Dolares");
            euros = Convert.ToSingle(Console.ReadLine());
            cambio = euros * tasaDolar;
            Console.WriteLine("La conversion es igual a: {0}", cambio);
        }
        


        
    }
}
