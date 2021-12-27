using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2TrainingManagementSystem
{
    class PracticalLesson : Training
    {
        string Task { get; set; }
        string Solution { get; set; }
        public PracticalLesson(string description, string task, string solution) : base (description)
        {
            Task = task;
            Solution = solution;
            
            this.Add(this);
        }
    }
}
