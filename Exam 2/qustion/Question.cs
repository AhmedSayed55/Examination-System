using Exam_2.answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2.qustion
{
    internal abstract class Question 
    {
        #region constructors

        public Question()
        {
            RightAnswer = new Answer();
            InputAnswers = new Answer();
        }

        #endregion

        #region properties and methods

        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer InputAnswers { get; set; }

        #endregion

        #region methods
        public abstract void CreateQuestion();
        public override string ToString()
        {
            return $"{Header} {Mark} Marks\n {Body}";
        }

        #endregion

    }
}
