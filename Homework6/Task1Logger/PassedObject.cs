using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logger
{
    [TrackingEntity]
    class PassedObject
    {
        [TrackingProperty("Name")]
        string Name { get; }
        int Age { get; }

        [TrackingProperty("Phone number")]
        string PhoneNumber { get; set; }
        string EmailAddress { get; set; }

        public PassedObject(string name, int age, string phone, string email)
        {
            Name = name;
            Age = age;
            PhoneNumber = phone;
            EmailAddress = email;
        }

        public int GetYearOfBirth()
        {
            int dob = (int)DateTime.Today.Year - Age;
            return dob;
        }

        public override string ToString()
        {
            StringBuilder temp = new();
            temp.Append($"Person Name: {Name}, Age: {Age}, Phone Nr.: {PhoneNumber}, Email: {EmailAddress}");
            return temp.ToString();
        }
    }
}
