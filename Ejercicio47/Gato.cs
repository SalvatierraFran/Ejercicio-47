using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    class Gato:Animal, Mascota
    {
        /*Atributo*/
        private string _nombre;

        /*Constructor*/
        public Gato(string Nombre, int Patas):base(Patas)
        {
            this._nombre = Nombre;
        }

        /*Implementaciones de la clase "Animal"*/
        public override void Comer()
        {
            Console.WriteLine("Este animal come peces");
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
            Console.WriteLine("Este animal juega con pelotas de lana");
        }
    }
}
