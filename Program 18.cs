using System;

namespace DelegateExample
{
    // Define delegate
    public delegate void Student();

    class Program
    {
        // Method to be assigned to the delegate
        public static void StudentRecord()
        {
            Console.WriteLine("===== Student Record =====");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            string rollNo = Console.ReadLine();

            Console.Write("Enter Age: ");
            string age = Console.ReadLine();

            Console.Write("Enter Class: ");
            string className = Console.ReadLine();

            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine($"Name       : {name}");
            Console.WriteLine($"Roll No.   : {rollNo}");
            Console.WriteLine($"Age        : {age}");
            Console.WriteLine($"Class      : {className}");
        }

        static void Main(string[] args)
        {
            // Create a delegate instance and assign method
            Student studentDelegate = new Student(StudentRecord);

            // Invoke the delegate
            studentDelegate();
        }
    }
}
