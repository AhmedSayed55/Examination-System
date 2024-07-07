using Exam_2.answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2.qustion
{
    internal class TrueOrFalse : Question
    {

        #region constructors
        public TrueOrFalse()
        {
            AnswerList = new Answer[2]
            {
                new Answer(1,"true"),
                new Answer(2, "false")
            };
        }

        #endregion

        #region properties and attributes

        //public bool True { get; set; }
        //public bool False { get; set; }


        private string header;

        public override string Header
        {
            get
            {
                return header = "True | False Question";
            }
            //set
            //{
            //    header = value;
            //}
        }

        #endregion

        #region Methods
        public override void CreateQuestion()
        {
            Console.WriteLine(Header);

            do
            {
                Console.WriteLine("Enter the body of the question:");
                Body = Console.ReadLine();
            } while (string.IsNullOrEmpty(Body));


            bool flag1;
            int mark;
            do
            {
                Console.WriteLine("enter the mark of the question:");
                flag1 = int.TryParse(Console.ReadLine(), out mark);
            }while (!flag1 || mark <= 0);
            Mark = mark;

            bool flag2;
            int RightAnswerID;
            do
            {
                Console.WriteLine("enter the rigth answer for the question: (1 for true and 2 for false):");
                flag2 = int.TryParse(Console.ReadLine(), out RightAnswerID);
            }while (!flag2 || (RightAnswerID <1 || RightAnswerID > 2) );

            RightAnswer.AnswerId = RightAnswerID;
            RightAnswer.AnswerTexet = AnswerList[RightAnswerID - 1].AnswerTexet;

        }

        #endregion

    }
}
