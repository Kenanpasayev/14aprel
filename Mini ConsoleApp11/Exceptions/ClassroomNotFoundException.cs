using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ConsoleApp11.Exceptions
{
    internal class ClassroomNotFoundException:Exception
    {
        public ClassroomNotFoundException() 
        {

        } 

        public ClassroomNotFoundException(string message):base(message)
        {
            
        }
    }
}
