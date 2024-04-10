using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examination_System
{
    public class MCQ : Question
    {
        #region Properties [Header Override]
        public override string Header => "MCQ Question";
        #endregion

        #region Constructor
        public MCQ()
        {
            AnswersList = new Answer[3];
        }
        #endregion

        #region Methods [Overriding AddQuestion()]
        public override void AddQuestion()
        {
            // Header
            Console.WriteLine(Header);
            // Body
            Console.WriteLine("Please Enter Body of the Question:");
            Body = Console.ReadLine();
            // Mark
            int mark;
            do
            {
                Console.WriteLine("Please Enter The Mark of the Question:");
            } while (!int.TryParse(Console.ReadLine() , out mark));
            Marks = mark;
            // Choices of the Question
            Console.WriteLine("Enter The Choices of the Questions: ");
            for (int i = 0; i < 3; i++) 
            {
                AnswersList[i] = new Answer()
                {
                    AnswerId = i+1,
                };
                Console.WriteLine($"Please Enter The Choice Number {i+1}:");
                AnswersList[i].AnswerText = Console.ReadLine();
            }
            // Specify Right answer
            int rightAnswerId;
            do
            {
                Console.WriteLine("Please Specify The Right Answer:");

            } while (!int.TryParse(Console.ReadLine() ,out rightAnswerId) && rightAnswerId < 1 || rightAnswerId > 3);
            RightAnswer.AnswerId = rightAnswerId;
            RightAnswer.AnswerText = AnswersList[rightAnswerId-1].AnswerText;
            Console.Clear();

        } 

        #endregion
    }
}