using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Queen : Bee
    {

        public Queen(Worker[] workers) : base(275)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber = 0;

        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }

        public string WorkTheNextShift()
        {
            double totalConsumption = 0;
            for (int i = 0; i < workers.Length; i++)
                totalConsumption += workers[i].GetHoneyConsumption();
            totalConsumption += GetHoneyConsumption();

            // ... here’s where the original code for this method goes, minus the return statement

            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                    if (workers[i].ShiftLeft > 0)
                    report += "Worker #" + (i + 1) + " is doing ‘" + workers[i].CurrentJob
                        + "’ for " + workers[i].ShiftLeft + " more shifts\r\n";
                else
                    report += "Worker #" + (i + 1) + " will be done with ‘"
                        + workers[i].CurrentJob + "’ after this shift\r\n";
            }

            // End of the original code for this method

            report += "Total honey consumption: " + totalConsumption + " units";
            return report;
        }
    }
}
