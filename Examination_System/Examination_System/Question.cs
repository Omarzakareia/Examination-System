using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examination_System
{
    public abstract class Question
    {
        #region Attributes & Properties
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Marks { get; set; }


        #region Question Answers
        public Answer[] AnswersList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }
        #endregion


        #endregion

        #region Constructors
        protected Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }
        #endregion

        #region Methods

        public abstract void AddQuestion();
        public override string ToString()
        {
            return $"{Header}\t Mark({Marks})\n-------------------------------------\n{Body}";
        }
        #endregion
    }
}