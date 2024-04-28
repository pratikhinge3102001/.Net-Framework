using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Phone { get; set; }

        //default
        public Student() {
        }

        //Parametrised Constructor
        public Student(int id, string name, string firstName, string lastName, string email, string phone)
        {
            Id = id;
            Name = name;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        //Copy Constructor
        public Student(Student student)
        {
            Console.WriteLine("Copy Constructor");
            Id = student.Id;
            Name = student.Name;
            FirstName = student.FirstName;
            LastName = student.LastName;
            Email = student.Email;
            Phone = student.Phone;

        }
        //Tostring
        public override string ToString()
        {
            return $"{Id} -{Name}-{FirstName}-{LastName}-{Email}-{Phone}";
        }

        ~Student() {
            Console.WriteLine("Destructor");
        }
    }
}
