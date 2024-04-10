using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examination_System
{
    public class Answer
    {

        #region Attributes & Properties
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion

        #region Constructor
        public Answer(int answerId , string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        public Answer()
        {
            
        }
        #endregion

        #region Overriding ToString()
        public override string ToString()
        {
            return $"{AnswerId}-{AnswerText}";
        }
        #endregion
    }
}