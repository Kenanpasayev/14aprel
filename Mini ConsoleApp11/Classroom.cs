using Mini_ConsoleApp11.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ConsoleApp11
{
    internal class Classroom
    {
        private int _id;
        public int Id { get; set; }
       
        public string Name { get; set; }
        public Student[] Students;
        int _studentlimit;
        public int Studentlimit 
        { 
            get 
            { 
                return _studentlimit;
            } 
            set 
            {
                if (value == 1)
                {
                    _studentlimit = Convert.ToInt32(ClassType.Frontend);
                }
                else if (value == 2)
                {
                    _studentlimit = Convert.ToInt32(ClassType.Backend);
                }
             
            }
        }
       
        public Classroom(string name, int limit )
        {
            Students = new Student[0];
            Id = _id++;
            Name = name;
            Studentlimit = limit;

           
        }
        public void StudentAdd(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public Student FindId(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
        public void DeleteStudent(int id)
        {
            Student[] newstudents =new  Student[0];
            foreach (Student student in Students) 
            {
                if ( student.Id != id)
                {
                  
                    return;
                }
                else
                {
                    throw new StudentNotFoundException("ID uygun telebe tapilmadi");
                }
            }
           
        }

    }
}

