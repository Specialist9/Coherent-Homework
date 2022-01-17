using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Task2TrainingManagementSystem
{

    public class Training : Entities, ICloneable
    {
        public List<Entities> Trainingslist { get; private set; } = new();
        
        public Training(string description) : base(description)
        {
            Description = description;
        }
        
        public void Add(Entities element)
        {
            this.Trainingslist.Add(element);
        }

        public bool IsPractical()
        {
            foreach(object element in Trainingslist)
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
            List<Entities> copyList = new();

            foreach (Entities item in Trainingslist)
            {
                var tempItem = item.Clone();
                copyList.Add((Entities)tempItem);
            }

            return new Training(Description)
            {
                Trainingslist = copyList
            };
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
