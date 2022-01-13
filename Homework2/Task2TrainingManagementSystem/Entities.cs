using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2TrainingManagementSystem
{
    public abstract class Entities : ICloneable
    {
        public string Description { get; set; }

        public Entities(string description)
        {
            Description = description;
        }

        public Entities()
        {

        }

        public object Clone()
        {
            return (Entities)MemberwiseClone();
        }
    }
}
