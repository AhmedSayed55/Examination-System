using Exam_2.qustion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2.exam
{
    internal class PracticalExam : Exam
    {
        #region constructors
        public PracticalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }

        #endregion

        #region methods
        public override void ShowExam()
        {
            if (ExamQuestions is not null)
            {
                for (int i = 0; i < ExamQuestions.Length; i++)
                {
                    Console.WriteLine(ExamQuestions[i]);
                    if (ExamQuestions[i].AnswerList is not null)
                    {
                        for (int j = 0; j < ExamQuestions[i].AnswerList.Length; j++)
                        {
                            Console.WriteLine(ExamQuestions[i].AnswerList[j]);
                        }
                    }
                    Console.WriteLine("-------------------------");

                    bool flag;
                    int InputAnswer;
                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out InputAnswer);
                    } while (!flag || (InputAnswer < 1 || InputAnswer > 3));
                    ExamQuestions[i].InputAnswers.AnswerId = InputAnswer;
                    ExamQuestions[i].InputAnswers.AnswerTexet = ExamQuestions[i].AnswerList[InputAnswer - 1].AnswerTexet;
                    Console.WriteLine($"your answer id is:{ExamQuestions[i].InputAnswers.AnswerId}");
                    Console.WriteLine($"your answer is:{ExamQuestions[i].InputAnswers.AnswerTexet}");
                    Console.WriteLine("--------------------------");
                }
                Console.WriteLine("the rigth answers are:");

                for (int i = 0; i < ExamQuestions.Length; i++)
                {
                    Console.WriteLine($"Q{i + 1}) {ExamQuestions[i].RightAnswer.AnswerId}) {ExamQuestions[i].RightAnswer.AnswerTexet}");
                }
            }
            else
            {
                Console.WriteLine("No questions found");
            }
        }
        #endregion

    }
}
