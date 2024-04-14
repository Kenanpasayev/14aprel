using Mini_ConsoleApp11.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mini_ConsoleApp11
{
    internal static class Helper
    {
      
        public static bool Name(string name) 
        {
            bool _name = false;
            if (char.IsUpper(name[0]) && name.Length >= 3)
            {
                _name = true;
            }
            else 
            { 
                throw new InvalidNameException($"Name boyuk heriften yazilmali : {name}");
            }
            return _name;
        }

        public static bool Surname(string surname)
        {
           bool _surname = false;
            if (char.IsUpper(surname[0]) && surname.Length >= 3)
            {
                _surname = true;
            }
            else 
            {
                throw new InvalidNameException($"Surname boyuk herifden baslamalidi : {surname}"); 
            }
            return _surname;
        }
        public static  bool ClassName(string className) 
        {
            bool _classname = false;
            if (char.IsUpper(className[0]) && char.IsUpper(className[1]) && char.IsDigit(className[2]) && char.IsDigit(className[3]) && char.IsDigit(className[4]))
            {
                _classname = true;
            }
            else
            {
                throw new InvalidNameException($"Classroom adi iki boyuk herf ve 3 reqemn olmalidir");
                
            }
            return _classname;
        }
    }
}
