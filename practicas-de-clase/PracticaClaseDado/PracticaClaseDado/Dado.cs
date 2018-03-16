using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClaseDado
{
    class Dado
    {
        Random rand;
        
        public Dado()
        {
            rand = new Random();
        }

        public int tirar()
        {
            return rand.Next(1, 7);
        } 
    }
}
