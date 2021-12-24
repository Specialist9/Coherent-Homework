using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2TrainingManagementSystem
{
    class Lecture : Training
    {
        //string Topic { get; set; }
        public Lecture(string description, string topic) : base(description)
        {
            //Topic = topic;
            //Console.WriteLine($"{description} / {topic} ");
            this.Add(this);
        }
    }
}
