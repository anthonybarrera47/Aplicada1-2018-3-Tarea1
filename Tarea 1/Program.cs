using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Registro().ShowDialog();
            Menu m = new Menu();
            m.ImprimirMenu();
            
        }
    }
}
