using System;

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton teacher = Singleton.GetInstance;
            teacher.PrintDetails("From teacher object");

            Singleton student = Singleton.GetInstance;
            student.PrintDetails("From student object");
            Console.ReadLine(); 
        }
    }
}
