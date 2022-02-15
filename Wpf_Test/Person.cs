using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Test
{
    internal class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? EmailAddress { get; set; }
        public GenderType Gender { get; set; }

        public enum GenderType
        {
            Female = 0,
            Male = 1,
            Other = 2
        }

        public Person() { }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
