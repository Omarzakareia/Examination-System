using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examination_System
{
    public class TF : Question
    {
        #region Properties [Header Override]
        public override string Header => "True Or False Question";


        #endregion

        #region Constructor
        public TF()
        {
            AnswersList = new Answer[2];
            AnswersList[0] = new Answer(1, "True");
            AnswersList[1] = new Answer(2, "False");
        }
        #endregion

        #region Methods
        public override void AddQuestion()
        {
            // Header
            Console.WriteLine(Header);

            //Body
            Console.WriteLine("Please Enter Body of the Question:");
            Body = Console.ReadLine();

            // Mark
            int mark;
            do
            {
                Console.WriteLine("Please Enter The Mark of the Question:");
            } while (!int.TryParse(Console.ReadLine(), out mark));
            Marks = mark;

            //RightAnswer
            int rightAnswerId;
            do
            {
                Console.WriteLine("Please Specify The Right Answer of the Question (1 For True & 2 For False):");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) && rightAnswerId < 1 || rightAnswerId > 2);
            RightAnswer.AnswerId = rightAnswerId;
            RightAnswer.AnswerText = AnswersList[rightAnswerId - 1].AnswerText;
            Console.Clear();
        }
        #endregion

    }
}