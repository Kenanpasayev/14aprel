using Mini_ConsoleApp11;
using Mini_ConsoleApp11.Exceptions;

namespace Mini_ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Classroom[]classroom = new Classroom[0];
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Sinif yarat");
                Console.WriteLine("2. Telebe yarat");
                Console.WriteLine("3. Butun telebeleri ekrana cixart");
                Console.WriteLine("4. Secilmis sinifdeki telebeleri ekrana cixart");
                Console.WriteLine("5. Telebe sil");
                Console.WriteLine("0. Cixis");

                Console.Write("Seciminizi daxil edin: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("CLassroom adi daxil edin");
                            string classroomname = Console.ReadLine();
                            if (Helper.Name(classroomname))
                            {
                                Console.WriteLine("CLass type yazin");
                                Console.WriteLine("1-Frontend");
                                Console.WriteLine("2-BackEnd");

                                int classtype = Convert.ToInt32(Console.ReadLine());
                                if (classtype == 1 | classtype == 2)
                                {
                                    Classroom class1 = new Classroom(classroomname, classtype);
                                    Console.WriteLine($" Class name:{class1.Name}, Class Id:{class1.Id}, Class Limit:{class1.Studentlimit}");
                                    Array.Resize(ref classroom, classroom.Length + 1);
                                    classroom[^1] = class1;
                                }
                                else
                                {
                                    Console.WriteLine("Class type wrong");
                                }

                            }
                        }
                        catch (InvalidNameException ex)
                        {

                            Console.WriteLine(ex.Message);

                        }


                        break;
                    case "2":
                        try
                        {
                            if (classroom.Length != 0)
                            {
                                Console.WriteLine("Student name daxil edin");
                                string studentname = Console.ReadLine();
                                Console.WriteLine("Student surname daxil edin");
                                string studentsurname = Console.ReadLine();
                                Console.WriteLine("Class secin");
                                string classname = Console.ReadLine();
                                foreach (Classroom classrooms in classroom)
                                {
                                    if (classrooms.Name.ToLower() == classname.ToLower())
                                    {
                                        Student newstudent1 = new Student(studentname, studentsurname);

                                        if (newstudent1.Id < classrooms.Studentlimit)
                                        {
                                            classrooms.StudentAdd(newstudent1);
                                            Console.WriteLine($"Student elave olundu. Id:{newstudent1.Id}, Adi:{newstudent1.Name}, Soyadi : {newstudent1.Surname}");
                                            Console.WriteLine($"Elave olundugu class : {classrooms.Name}, class id: {classrooms.Id} ");

                                        }
                                    }

                                }

                            }


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }


                        break;
                    case "3":
                        try
                        {
                            foreach (Classroom classrooms in classroom)
                            {
                                foreach (Student students in classrooms.Students)
                                {
                                    Console.WriteLine($"{classrooms.Name}");
                                    students.ShowInfo();
                                }
                            }

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":

                        try
                        {
                            Console.WriteLine("Classroomu secin (adini daxil edin)");
                            foreach (Classroom classrooms in classroom)
                            {
                                Console.WriteLine($"{classrooms.Name}");
                            }
                            int class2 = Convert.ToInt32(Console.ReadLine());
                            foreach (Classroom classrooms in classroom)
                            {

                               foreach (Student student in classrooms.Students)
                               {
                                  student.ShowInfo();
                               }

                            }
                             

                        }
                        catch
                        {

                        }
                        break;
                    case "5":
                         try
                         {
                            Console.WriteLine("Id daxil ederek student silin");
                            int id=Convert.ToInt32(Console.ReadLine());
                            foreach (Classroom newrooms in classroom)
                            {
                                newrooms.DeleteStudent(id);
                                Console.WriteLine("Student silindi");
                                
                            }

                         }
                         catch (StudentNotFoundException ex)
                         {

                            Console.WriteLine(ex.Message);
                         }
                        
                        break;
                    case "0":
                        exit = true;
                        return;
                    default:
                        Console.WriteLine("Choose the correct");
                        break;
                }
            } while (exit != true);

        }
  
    }
}
