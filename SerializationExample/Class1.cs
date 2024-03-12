using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationExample
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Student()
        { }
        public override string ToString()
        {
            return $"student detials are: "+
                $"Name: {Name}, " +
                $"Age: {Age}, " +
                $"Username: {Username}, " +
                $"Password: {Password}";
        }
    }
}
