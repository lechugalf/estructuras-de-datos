using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClaseVector
{
    class MiVector
    {
        private int[] vector;
        private int len;
        private Random rand;

        public MiVector(int len)
        {
            this.len = len;
            vector = new int[len];
            rand = new Random();
        }

        public void fill()
        {
            for (int i = 0; i < len; i++)
                vector[i] = i + 1;
        }

        public void fill(int lim)
        {
            for (int i = 0; i < len; i++)
                vector[i] = rand.Next(lim + 1);
        }

        public int sum()
        {
            int sum = 0;
            foreach(int e in vector)
                sum += e;
            return sum;
            //return vector.Sum();
        }

        public double mean()
        {
            return sum() / (double)len;
            //return vector.Average();
        }

        public string show()
        {
            string str = "->" + Environment.NewLine;
            for (int i = 0; i < len; i++)
                str += "[" + i + "] = " + vector[i] + Environment.NewLine;
            return str;
        }

        public string showinv()
        {
            string str = "->" + Environment.NewLine;
            for (int i = len-1; i >=0; i--)
                str += "[" + i + "] = " + vector[i] + Environment.NewLine;
            return str;
        }

        public void girarArriba(int begin=0)
        {
            int temp = vector[len - 1];
            for(int e = len-1; e >begin; e--)
                vector[e] = vector[e-1];
            vector[begin] = temp;
        }

        public void girarAbajo()
        {
            int temp = vector[0];
            for (int e = 0; e < len-1; e++)
                vector[e] = vector[e + 1];
            vector[len-1] = temp;
        }

        public void invertir()
        {
            for(int x = 0; x < len-1; x++)
                girarArriba(x);
        }
    }
}
