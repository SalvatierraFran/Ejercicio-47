using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public abstract class Animal
    {
        protected int _patas;

        public Animal(int Patas)
        {
            this._patas = Patas;
        }

        public virtual void Caminar()
        {
            Console.WriteLine("Este animal camina sobre " + this._patas + " patas");
        }

        public abstract void Comer();
    }
}
