using System;
using System.Text;

namespace working_with_text
{
    class Program
    {
        static void Main()
        {
            doApp();
        }

        static void doApp()
        {
            string studentName = "John Doe";
            int studentID = 12345;
            string studentMajor = "Computer Science";

            string studentInfo = "Name: " + studentName + ", ID: " + studentID + ", Major: " + studentMajor;

            Console.WriteLine("Using string concatenation:");
            Console.WriteLine(studentInfo);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Name: ").Append(studentName).Append(", ID: ").Append(studentID).Append(", Major: ").Append(studentMajor);

            Console.WriteLine("\nUsing StringBuilder:");
            Console.WriteLine(stringBuilder);
            Console.ReadLine();
        }
    }
}

