using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examination_System
{
    public class Subject
    {
        #region Properties & Attributes
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }
        #endregion

        #region Constructor
        public Subject(int subjectId , string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        } 
        #endregion

        #region Methods
        public void CreateExam()
        {
            int ExamType, Time, NumOfQuestions;
            bool flag;
            do
            {
                Console.Write("Please Enter The Type Of the Exam to Create (1: Practical and 2: Final):  ");
                flag = int.TryParse(Console.ReadLine(), out ExamType);
            } while (!flag && ExamType < 1 && ExamType > 2);
            do
            {
                Console.Write("Enter The Time Of the Exam in minutes (from 30 to 180 min):   ");
                flag = int.TryParse(Console.ReadLine(), out Time);
            } while (!flag && Time < 30 && Time > 180);
            do
            {
                Console.Write("Enter The Number Of Questions the Exam:  ");
                flag = int.TryParse(Console.ReadLine(), out NumOfQuestions);
            } while (!flag);
            Console.Clear();

            if(ExamType == 1)
                SubjectExam = new PracticalExam(Time, NumOfQuestions);
            else
                SubjectExam = new FinalExam(Time, NumOfQuestions);
            Console.Clear();

            //Calling Function To Create List of Questions based on the type of the exam
            SubjectExam.CreateListOfQuestion();


        }
        #endregion
    }
}