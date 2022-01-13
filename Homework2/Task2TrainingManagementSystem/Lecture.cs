using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task2TrainingManagementSystem
{
    public class Lecture : Entities
    {
        public string Topic { get; set; }
        public Lecture(string description, string topic) : base(description)
        {
            Topic = topic;
        }

        public Lecture()
        {

        }

    }
}
