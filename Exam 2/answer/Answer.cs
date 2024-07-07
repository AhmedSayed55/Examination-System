using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2.answer
{
    internal class Answer
    {

        #region constructors
        public Answer(int answerId, string answerTexet)
        {
            AnswerId = answerId;
            AnswerTexet = answerTexet;
        }

        public Answer()
        {
        }
        #endregion

        #region properties and attributes
        public int AnswerId { get; set; }
        public string AnswerTexet { get; set; }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"{AnswerId} : {AnswerTexet}";
        }

        #endregion

    }
}
