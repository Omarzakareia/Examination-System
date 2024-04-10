using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examination_System
{
    public class FinalExam : Exam
    {

        #region Constructor
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {

        }
        #endregion

        #region Methods
        public override void CreateListOfQuestion()
        {
            ListOfQuestion = new Question[NumberOfQuestion];
            for (int i = 0; i < NumberOfQuestion; i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("Please Enter Type Of The Question (1 for Mcq | 2 For True or False Question):");

                } while (!int.TryParse(Console.ReadLine(), out choice) && choice < 1 || choice > 2);
                Console.Clear();
                if (choice == 1)
                {
                    ListOfQuestion[i] = new MCQ();
                    ListOfQuestion[i].AddQuestion();
                }
                else
                {
                    ListOfQuestion[i] = new TF();
                    ListOfQuestion[i].AddQuestion();
                }
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

            // Show Results : Questions , answers , Grade
            int TotalMarks = 0, Grade = 0;
            Console.WriteLine("Your Answers: \n");
            for (int i = 0; i < ListOfQuestion.Length; i++)
            {
                TotalMarks += ListOfQuestion[i].Marks;
                if (ListOfQuestion[i].RightAnswer.AnswerId == ListOfQuestion[i].UserAnswer.AnswerId)
                {
                    Grade += ListOfQuestion[i].Marks;
                }
                Console.WriteLine($"Q{i + 1}) {ListOfQuestion[i].Body}");
                Console.WriteLine($"Your Answer => {ListOfQuestion[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right Answer => {ListOfQuestion[i].RightAnswer.AnswerText}");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Your Grade is {Grade} from {TotalMarks}");
            }
        }
        #endregion



    }
}