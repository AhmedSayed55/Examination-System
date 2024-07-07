using Exam_2.qustion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2.exam
{
    internal abstract class Exam
    {
        #region constructors

        protected Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }

        #endregion

        #region properties and attributes

        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] ExamQuestions { get; set; }

        #endregion

        #region methods

        public abstract void ShowExam();

        #endregion
    }
}
