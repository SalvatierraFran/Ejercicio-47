using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Araña Arañita = new Araña(8);
            Pez UnPez = new Pez("Pepe", 0);
            Gato Gatito = new Gato("Felipe", 4);

            Console.WriteLine("Araña");
            Arañita.Caminar();
            Arañita.Comer();
            Arañita.Jugar();

            Console.WriteLine("\nGato");
            Console.WriteLine(Gatito.Nombre);
            Gatito.Caminar();
            Gatito.Comer();
            Gatito.Jugar();

            Console.WriteLine("\nPez");
            Console.WriteLine(UnPez.Nombre);
            UnPez.Caminar();
            UnPez.Comer();
            UnPez.Jugar();

            Console.ReadKey();
        }
    }
}
