using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    abstract class SerVivo
    {
        protected bool estaVivo;
        public bool EstaVivo { get { return estaVivo; } }

        public SerVivo()
        {
            estaVivo = true;
        }

        public override string ToString()
        {
            string str = "esta muerto";
            if (estaVivo)
            {
                str = "esta vivo";
            }
            return str;
        }
    }
}
