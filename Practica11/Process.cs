using System;

namespace Practica11
{
    class Process
    {
        private int pid;
        private Process next;
        private int cycles;

        public Process(int pid, int cycles)
        {
            this.pid = pid;
            this.cycles = cycles;
        }

        public override string ToString()
        {
            //return string.Format("{0}", PID);
            //return string.Format("{0},{1}", PID, Cycles);
            return string.Format("PID:{0, -2} Cycles:{1, -2}", PID, Cycles);
        }

        public int PID 
        { 
            get { return pid; } 
            set { pid = value; } 
        }

        public Process Next 
        { 
            get{ return next; }
            set{ next = value;}
        }

        public int Cycles
        { 
            get { return cycles; }
            set { cycles = value; }
        }

        
    }
}
