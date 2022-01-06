using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2TrainingManagementSystem
{
    class PracticalLesson : Entities
    {
        public string Task { get; set; }
        public string Solution { get; set; }
        public PracticalLesson(string description, string task, string solution) : base (description)
        {
            Task = task;
            Solution = solution;
            
            //Training.Add(this);
        }
    }
}
