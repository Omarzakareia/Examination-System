using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examination_System
{
    public class PracticalExam : Exam
    {
        #region Constructor
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {

        }
        #endregion

        #region Methods
        public override void CreateListOfQuestion()
        {
            ListOfQuestion = new Question[NumberOfQuestion];
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                ListOfQuestion[i] = new MCQ();
                ListOfQuestion[i].AddQuestion();
                Console.Clear();
            }
        }
        public override void ShowExam()
        {
            // Show Exam and Take Answers from the User
            foreach (var Question in ListOfQuestion)
            {
                //Question
                Console.WriteLine(Question);
                // Answer Choices of The Question
                for (int i = 0; i < Question.AnswersList.Length; i++)
                {
                    Console.Write(Question.AnswersList[i] + "            ");
                }
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine();
                //User Answer
                int UserAnswerId;
                do
                {
                    Console.Write("Please Enter Number of Your Answer: ");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) && UserAnswerId < 1 || UserAnswerId > 3);
                Question.UserAnswer.AnswerId = UserAnswerId;
                Question.UserAnswer.AnswerText = Question.AnswersList[UserAnswerId - 1].AnswerText;
                Console.WriteLine("-------------------------------------------");
                Console.Clear();

            }

            // Show Right Answer
            Console.WriteLine("Right Answers \n");
            for (int i = 0; i < ListOfQuestion.Length; i++)
            {
                Console.WriteLine($"Q{i + 1}) {ListOfQuestion[i].Body}");
                Console.WriteLine($"Right Answer => {ListOfQuestion[i].RightAnswer.AnswerText}");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
            }
        }
        #endregion

    }
}