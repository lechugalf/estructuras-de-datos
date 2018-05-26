using System;

namespace Practica11
{
    class Processor
    {
        Process taskQueue;
        Process front;
        Random rand = new Random();

        public string ProccesTaskThread(int cycles, float inputP, int cycleTaskP)
        {
            int PID = 1;
            int emptyCycles = 0;
            int attendedTasks = 0;
            int unresolved = 0;


            for(int cycle = 0; cycle < cycles; cycle++)
            {
                if(rand.NextDouble() < inputP)
                {
                    
                }
            }

            return "";
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
    }
}
