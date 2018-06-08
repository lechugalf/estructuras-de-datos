using System;

namespace Practica13
{
    class Processor
    {
        private Process initProcess, currentProcess, lastProcess;
        private Random rand = new Random();
        private string log;

        public string Log { 
            get { return log; }
        }

        public void AppendProcess(Process newProcess)
        {
            if(initProcess != null)
            {
                lastProcess.Next = newProcess;
                newProcess.Next = initProcess;
                newProcess.Previous = lastProcess;
                initProcess.Previous = newProcess;
                lastProcess = newProcess;
            }
            else
            {
                initProcess = newProcess;
                lastProcess = newProcess;
                initProcess.Next = lastProcess;
                initProcess.Previous = lastProcess;
                currentProcess = initProcess;
            }
        }

        private void removeCurrent()
        {
            if(currentProcess != initProcess)
            {
                if(currentProcess != lastProcess)
                {
                    currentProcess.Previous.Next = currentProcess.Next;
                    currentProcess.Next.Previous = currentProcess.Previous;
                }
                else{
                    removeLast();
                }
            }
            else
            {
                removeFirst();
            }
        }

        private void removeFirst()
        {
            lastProcess.Next = initProcess.Next;
            initProcess.Next.Previous = lastProcess;
            initProcess = initProcess.Next;
        }

        private void removeLast()
        {
            lastProcess.Previous.Next = initProcess;
            initProcess.Previous = lastProcess.Previous;
            lastProcess = initProcess.Previous;
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

            currentProcess = initProcess;

            while(cycles > 0)
            {
                if(rand.NextDouble() < inputP)
                {
                    rnd = rand.Next(4, 15);
                    AppendProcess(new Process(++PID, rnd));
                    cyclesToProcess += rnd;
                    arrivedTasks++;
                }

                if(initProcess != null)
                {
                    currentProcess.Cycles--;
                    if(currentProcess.Cycles == 0)
                    {
                        removeCurrent();
                        attendedTasks++;
                    }
                    currentProcess = currentProcess.Next;
                }
                else
                    emptyCycles++;

                cycles--;
                
            }
            string report = "Procces Task Thread\n";
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
    }
}
