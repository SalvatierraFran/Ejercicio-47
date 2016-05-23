using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    class Pez:Animal, Mascota
    {
        /*Atrbuto*/
        private string _nombre;

        /*Constructor*/
        public Pez(string Nombre, int Patas):base(Patas)
        {
            this._nombre = Nombre;
        }

        /*Implementacion de la clase abstracta "Animal"*/
        public override void Comer()
        {
            Console.WriteLine("Este animal come boludeces");
        }

        public override void Caminar()
        {
            base.Caminar();
        }

        /*Implementacion de la interface Mascota*/
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public void Jugar()
        {
            Console.WriteLine("Este animal juega en el agua");
        }
    }
}
