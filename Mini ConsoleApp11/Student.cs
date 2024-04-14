using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ConsoleApp11
{
    internal class Student
    {
        private int _id;
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Id = _id++;
            Name = name;
            Surname = surname;

        }
        public void ShowInfo ()
        {
            Console.WriteLine($"Student id:{Id} , Student name:{Name} , Student surname {Surname}");
        }
    }
}
