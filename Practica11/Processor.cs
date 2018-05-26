using System;

namespace Practica11
{
    class Processor
    {
        private Process taskQueue;
        private Random rand = new Random();
        private string log;

        public string Log { 
            get { return log; }
        }

        public void ProcessTaskThread(int cycles, double inputP)
        {
            int PID = 0;
            int arrivedTasks = 0;
            int emptyCycles = 0;
            int attendedTasks = 0;
            int unresolved = 0;
            int cyclesToProcess = 0;
            int missingCycles = 0;
            int rnd;

            string report = "Procces Task Thread\n";

            for(int cycle = 0; cycle < cycles; cycle++)
            {
                report += ListTaskQueue() + '\n';

                if(taskQueue != null)
                {
                    if(taskQueue.Cycles == 0)
                    {
                        attendedTasks++;
                        Dequeue();
                    }
                    else
                        taskQueue.Cycles--;
                }
                else
                    emptyCycles++;

                if(rand.NextDouble() < inputP)
                {
                    rnd = rand.Next(4, 15);
                    cyclesToProcess += rnd;
                    Enqueue( new Process(++PID, rnd));
                    arrivedTasks++;
                }
            }

            unresolved = PID - attendedTasks;
            missingCycles = cyclesToProcess - cycles-emptyCycles;

            report += "attendedTasks: " + attendedTasks + '\n' + 
                      "emptyCycles: " + emptyCycles + '\n' + 
                      "unresolved: " + unresolved + '\n'+
                      "missingCycles: " + missingCycles + '\n' +
                      "arrivedTasks: " + arrivedTasks;
            //return report;
            this.log = report;
        }

        private void Enqueue(Process newProcess)
        {   
            if(taskQueue != null)
            {
                Process position = taskQueue;
                while(position.Next != null)
                    position = position.Next;
                position.Next = newProcess;
            }
            else
            {
                taskQueue = newProcess;
            }
        }

        private void Dequeue()
        {
            if(taskQueue != null)
                taskQueue = taskQueue.Next;
        }

        private string ListTaskQueue()
        {
            string str = "";

            if(taskQueue != null)
            {
                Process pos = taskQueue;
                while(pos != null)
                {
                    str += "[" + pos.ToString() + "]";
                    pos = pos.Next;
                }
            }
            else
            {
                str = "nothing to process..";
            }
            return str;
        }
    }
}
