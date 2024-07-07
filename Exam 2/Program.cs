using Exam_2.qustion;
using Exam_2.subject;
using System.Diagnostics;

namespace Exam_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char confirm;
            Subject sub1 = new Subject(10, "c#");
            sub1.CreateExam();
            Console.Clear();
            Console.Write("Do you want To Start The Exam (y|n):");
            char.TryParse(Console.ReadLine(), out confirm);
            if (confirm == 'y') 
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                sub1.Exam.ShowExam();
                sw.Stop();
                Console.WriteLine($"the Elapsed time : {sw.Elapsed}");

                if (sw.Elapsed.TotalMinutes > sub1.Exam.TimeOfExam)
                {
                    Console.Clear();
                    Console.WriteLine("Time is up. You have failed");
                }
            }
        }
    }
}
