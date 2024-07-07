using Exam_2.answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2.qustion
{
    internal class MCQ : Question 
    {
        #region constructors

        public MCQ() 
        {
            AnswerList = new Answer[3];
            
        }

        #endregion

        #region properties and attributes
        //public string Choice1 { get; set; }
        //public string Choice2 { get; set;}
        //public string Choice3 { get; set;}

        private string header;

        public override string Header
        {
            get
            {
                return header = "MCQ Question";
            }
        }
        #endregion

        #region methods

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
            } while (!flag1 || mark <= 0);
            Mark = mark;

            Console.WriteLine("enter the choises for the question:");
            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answer()
                {
                    AnswerId = i + 1,
                };
                do
                {
                    Console.Write($"please enter the choice number {i + 1}:");
                    AnswerList[i].AnswerTexet = Console.ReadLine();
                } while (string.IsNullOrEmpty(AnswerList[i].AnswerTexet));

            }

            bool flag2;
            int RightAnswerID;
            do
            {
                Console.WriteLine("specify the rigth anser for the question:");
                flag2 = int.TryParse(Console.ReadLine(), out RightAnswerID);
            } while (!flag2 || (RightAnswerID < 1 || RightAnswerID > 3));

            RightAnswer.AnswerId = RightAnswerID;
            RightAnswer.AnswerTexet = AnswerList[RightAnswerID - 1].AnswerTexet;

            #endregion

        }
    }
}
