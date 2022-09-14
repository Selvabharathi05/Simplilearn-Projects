using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SchoolLibrary;


namespace SchoolData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            AcceptandPrintStudentData();
            AcceptandPrintTeacherData();
            AcceptandPrintSubjectData();
            Console.ReadLine();
        }
       

        public static void AcceptandPrintStudentData()
        {
            Student s = new Student();
            Console.WriteLine("Enter the Student Details");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter the Student name");
            s.StudName = Console.ReadLine();
            Console.WriteLine("Enter the Class");
            s.Standard = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Section");
            s.Section = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("--------------------------");
            Console.WriteLine("Printing the Student Details");
            Console.WriteLine("Student Name :" +s.StudName);
            Console.WriteLine("Class :" +s.Standard);
            Console.WriteLine("Section :" +s.Section);
            Console.WriteLine("---------------------------");
        }

        public static void AcceptandPrintTeacherData()
        {
            Teacher t = new Teacher();
            Console.WriteLine("Enter the Teacher Details");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter the Teacher Name");
            t.TeacherName = Console.ReadLine();
            Console.WriteLine("Enter the Subject Name");
            t.SubjectName = Console.ReadLine();
            Console.WriteLine("Enter the Standard");
            t.Standard = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Section");
            t.Section = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("-------------------------");
            Console.WriteLine("Printing the Teacher Details");
            Console.WriteLine("Teachers Name :" +t.TeacherName);
            Console.WriteLine("Subject Name :" +t.SubjectName);
            Console.WriteLine("Class :" +t.Standard);
            Console.WriteLine("Section :" +t.Section);
            Console.WriteLine("------------------------------");

        }

        public static void AcceptandPrintSubjectData()
        {
            Subject s1 = new Subject();
            Console.WriteLine("Enter the Subject Details");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter the Subject Name");
            s1.SubjectName = Console.ReadLine();
            Console.WriteLine("Enter the Subject Code");
            s1.Subcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Printing the Subject Details");
            Console.WriteLine("Subject Name :" +s1.SubjectName);
            Console.WriteLine("Subject Code :" +s1.Subcode);
            Console.WriteLine("-----------------------------");


        }


    }

}

==============================================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace SchoolLibrary
{
    public class Student
    {
        public string StudName { get; set; }
        public int  Standard { get; set; }

        public char Section { get; set; }
   

    }

    public class Teacher : Student
    {
        public string TeacherName { get; set; } 

        public string SubjectName { get; set; }

     
    }

    public class Subject : Teacher
    {
        public int Subcode { get; set; }

        
    }
    
}
