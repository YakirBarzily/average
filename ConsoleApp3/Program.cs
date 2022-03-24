using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            int i;
            int average = 0;
            Console.WriteLine("please enter" + grades.Length + "grades");
            for (i = 0; i < grades.Length; i++)
                grades[i] = int.Parse(Console.ReadLine());

            for (i = 0; i < grades.Length; i++)

                for (i = 0; i < grades.Length; i++)
                    average += grades[i];
            average = average / grades.Length;
            Console.WriteLine("your average is :{0}", average);
        }
    }
}
