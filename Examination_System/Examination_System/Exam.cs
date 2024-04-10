using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examination_System
{
    public abstract class Exam
    {
        #region Attributes & Properties
        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public Question[] ListOfQuestion { get; set; } 
        #endregion

        #region Constructors
        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestion = numberOfQuestions;           
        }
        #endregion

        #region Methods
        public abstract void ShowExam();
        public abstract void CreateListOfQuestion();

        #endregion
    }
}