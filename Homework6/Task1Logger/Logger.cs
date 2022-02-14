using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

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
            var objType = testObject.GetType(); //get passed object type

            Dictionary<string, string> PropsAndValues = new(); // initialize dictionary for (property name : property value) pairs

            PropertyInfo[] props = objType.GetProperties(); //get an array of properties for passed object type

            if (testObject.GetType().GetCustomAttributes<TrackingEntityAttribute>() != null) // if there is a custom attribute TrackingEntity
            {
                foreach (var prop in props) // go through all properties of passed object type
                {
                    object[] CustomAttributes = prop.GetCustomAttributes(false); // get an array of all custom attributes (subclasses not checked)

                    foreach (var attr in CustomAttributes) // go through all the custom attributes
                    {
                        TrackingPropertyAttribute trackA = attr as TrackingPropertyAttribute; // initialize trackA variable as TrackingProperty
                        string attrName;
                        string propValue;

                        if (trackA != null) // if TrackingPropertyAttribute exists
                        {
                            if (trackA.Name != null) // if TrackingPropertyAttribute has a name
                            {
                                attrName = trackA.Name; // assign TrackingPropertyAttribute name to attrName
                            }
                            else
                            {
                                attrName = prop.Name; // else assign Property name to attrName
                            }

                            propValue = (prop.GetValue(testObject, null)).ToString(); // get Property value and assign tp propValue

                            PropsAndValues.Add(attrName, propValue); // add name and value to dictionary
                        }
                    }
                }

                string json = JsonSerializer.Serialize(PropsAndValues);
                File.WriteAllText(FileName, json);
                Console.WriteLine(File.ReadAllText(FileName));
            }
        }

    }
}
