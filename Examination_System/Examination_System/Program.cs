using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject(10, "c#");
            sub1.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start The Exam ( y | n ): ");


            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                sub1.SubjectExam.ShowExam();
                Console.WriteLine($"The Elapsed Time =  {sw.Elapsed}");
            }
        }
    }
}
