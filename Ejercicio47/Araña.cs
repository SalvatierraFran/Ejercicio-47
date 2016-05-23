using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    class Araña:Animal, Mascota
    {
        /*Constrcutor*/
        public Araña(int Patas):base(Patas)
        { }

        /*Implementacion de la clase abstracta "Animal"*/
        public override void Comer()
        {
            Console.WriteLine("Este animal come insectos");
        }

        public override void Caminar()
        {
            base.Caminar();
        }

        /*Implementacion de la interface */
        public string Nombre
        {
            get
            {
                return this.Nombre;
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Jugar()
        {
            Console.WriteLine("Este animal no juega");
        }
    }
}
