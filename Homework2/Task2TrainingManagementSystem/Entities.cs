using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2TrainingManagementSystem
{
    abstract class Entities
    {
        public string Description { get; set; }

        public Entities(string description)
        {
            Description = description;
        }
    }
}
