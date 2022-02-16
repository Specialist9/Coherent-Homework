using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace AttributeLibrary
{
    public class Logger
    {
        public string FileName { get; }

        public Logger(string fileName)
        {
            FileName = fileName;
        }

        public void Track(object testObject)
        {
            var objType = testObject.GetType(); //get passed object type

            Dictionary<string, string> propsAndValues = new(); // initialize dictionary for (property name : property value) pairs


            if (testObject.GetType().GetCustomAttributes<TrackingEntityAttribute>() != null) // if there is a custom attribute TrackingEntity
            {
                MemberInfo[] members = objType.GetProperties().Cast<MemberInfo>().Concat(objType.GetFields()).ToArray(); //get an array of all properties & fields of passed object type

                foreach (var prop in members) // go through all properties & fields of passed object type
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


                            propValue = prop.MemberType == MemberTypes.Property ? ((PropertyInfo)prop).GetValue(testObject).ToString() : ((FieldInfo)prop).GetValue(testObject).ToString();
                            //if member is Property get value of Property else get value of Field and put it to string

                            propsAndValues.Add(attrName, propValue); // add name and value to dictionary
                        }
                    }
                }

                string json = JsonSerializer.Serialize(propsAndValues);
                File.WriteAllText(FileName, json);
                Console.WriteLine(File.ReadAllText(FileName));

                
            }
        }

    }
}
