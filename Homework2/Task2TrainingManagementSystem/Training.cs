using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2TrainingManagementSystem
{
    class Training : Entities, ICloneable
    {
        
        public List<Entities> Trainingslist = new List<Entities>();
        
        public Training(string description) : base(description)
        {
            Description = description;
        }

        public void Add(Entities element)
        {
            this.Trainingslist.Add(element);
        }

        public static bool IsPractical(List<Entities> Testinglist)
        {
            foreach(object element in Testinglist)
            {
                if(element is Lecture)
                {
                    return false;
                }
            }
            return true;
        }

        public object Clone()
        {
            List<Entities> CopyList = new List<Entities>();

            foreach(var item in Trainingslist)
            {
                CopyList.Add(item);
            }

            var TrainingClone = new Training(this.Description)
            {
                Trainingslist = CopyList
            };
            
            return TrainingClone;

        }

        public override string ToString()
        {
            StringBuilder temp = new();
            foreach(var item in Trainingslist)
            {
                temp.Append($" {item},\n");
            }
            return temp.ToString();
        }

    }
}
