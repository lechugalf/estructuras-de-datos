using System;

namespace Primos
{
    
    class Primos
    {
        private int[] vector;
        private void calcular()
        {
            int f = 2;
            while(Math.Pow(f, 2) < vector.Length)
            {
                for(int i = f; i < vector.Length; i++)
                    if(((i+1) % f) == 0) vector[i] = 0;
                f++;
            }
        }

        public Primos(int num)
        {
            vector = new int[num];
            for(int i = 0; i < num; i++)
                vector[i] = 1;
            calcular();
        }

        public string fprimos()
        {
            string str = "";
            for(int i = 1; i < vector.Length; i++)
                if(vector[i] == 1) str  += (i+1) + ", ";
            return str;
        }
    }
}