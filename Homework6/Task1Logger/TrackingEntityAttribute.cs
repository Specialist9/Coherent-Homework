using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logger
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class TrackingEntityAttribute : Attribute
    {
        public TrackingEntityAttribute()
        {

        }
    }
}
