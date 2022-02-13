using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task1Logger
{
    class Logger
    {
        public string FileName { get; }

        public Logger(string fileName)
        {
            FileName = fileName;
        }

        public void Track(object testObject)
        {
            var objType = testObject.GetType();

            Dictionary<string, string> PropsAndValues = new();

            PropertyInfo[] props = objType.GetProperties();

            if (testObject.GetType().GetCustomAttributes<TrackingEntityAttribute>() != null)
            {
                foreach (var prop in props)
                {
                    object[] CustomAttributes = prop.GetCustomAttributes(true);

                    foreach (var attr in CustomAttributes)
                    {
                        TrackingPropertyAttribute trackA = attr as TrackingPropertyAttribute;
                        string attrName;
                        string propValue;

                        if (trackA != null)
                        {
                            if (trackA.Name != null)
                            {
                                attrName = trackA.Name;
                                propValue = (prop.GetValue(testObject, null)).ToString();
                            }
                            else
                            {
                                attrName = prop.Name;
                                propValue = (prop.GetValue(testObject, null)).ToString();
                            }

                            PropsAndValues.Add(attrName, propValue);
                        }
                    }
                }

                foreach (var dic in PropsAndValues)
                {
                    Console.WriteLine($"{dic.Key} : {dic.Value}");
                }
            }
        }

    }
}
