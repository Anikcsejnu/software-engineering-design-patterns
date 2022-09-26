using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintStudentDetails(),
                () => PrintTeacherDetails()
            ); 

            Console.ReadLine();
        }

        private static void PrintStudentDetails()
        {
            Singleton student = Singleton.GetInstance;
            student.PrintDetails("From student object");
        }
         
        private static void PrintTeacherDetails()
        {
            Singleton teacher = Singleton.GetInstance;
            teacher.PrintDetails("From teacher object");
        }
    }
}
