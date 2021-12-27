using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2TrainingManagementSystem
{
    class Training : Entities, ICloneable
    {
        
        public static List<object> Trainingslist = new List<object>();
        
        public Training(string description) : base(description)
        {
            Description = description;
        }

        public void Add(object element)
        {
            Trainingslist.Add(element);
        }

        public bool IsPractical(List<object> Testinglist)
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
            
            List<object> Trainingslist = new List<object>(Training.Trainingslist);

            return new Training(this.Description);

        }

        //public int Sum() => 6 + 5;
    }
}
