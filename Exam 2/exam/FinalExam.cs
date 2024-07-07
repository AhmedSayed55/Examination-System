using Exam_2.qustion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2.exam
{
    internal class FinalExam : Exam
    {
        #region constructors

        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }

        #endregion

        #region methods
        public override void ShowExam()
        {
            int TotalMarks = 0, Grade = 0;
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

                    bool flag1, flag2;
                    int InputAnswer;
                    if (ExamQuestions[i].Header == "MCQ Question")
                    {
                        do
                        {
                            flag1 = int.TryParse(Console.ReadLine(), out InputAnswer);
                        } while (!flag1 || (InputAnswer < 1 || InputAnswer > 3));
                        ExamQuestions[i].InputAnswers.AnswerId = InputAnswer;
                        ExamQuestions[i].InputAnswers.AnswerTexet = ExamQuestions[i].AnswerList[InputAnswer - 1].AnswerTexet;
                        Console.WriteLine($"your answer id is:{ExamQuestions[i].InputAnswers.AnswerId}");
                        Console.WriteLine($"your answer is:{ExamQuestions[i].InputAnswers.AnswerTexet}");
                        Console.WriteLine("--------------------------");
                    }
                    else if (ExamQuestions[i].Header == "True | False Question")
                    {
                        do
                        {
                            flag2 = int.TryParse(Console.ReadLine(), out InputAnswer);
                        } while (!flag2 || (InputAnswer<1 || InputAnswer>2));
                        ExamQuestions[i].InputAnswers.AnswerId = InputAnswer;
                        ExamQuestions[i].InputAnswers.AnswerTexet = ExamQuestions[i].AnswerList[InputAnswer - 1].AnswerTexet;
                        Console.WriteLine($"your answer id is:{ExamQuestions[i].InputAnswers.AnswerId}");
                        Console.WriteLine($"your answer is:{ExamQuestions[i].InputAnswers.AnswerTexet}");
                        Console.WriteLine("--------------------------");
                    }
                    TotalMarks += ExamQuestions[i].Mark;
                }
                for (int i = 0; i < ExamQuestions.Length; i++)
                {
                    if (ExamQuestions[i].RightAnswer.AnswerId == ExamQuestions[i].InputAnswers.AnswerId)
                    {
                        Grade += ExamQuestions[i].Mark;
                    }
                    Console.WriteLine($"Q{i + 1}) {ExamQuestions[i].Body}");
                    Console.WriteLine($"the rigth answer is: {ExamQuestions[i].RightAnswer.AnswerId}) {ExamQuestions[i].RightAnswer.AnswerTexet}");
                }
                Console.WriteLine($"your grade is {Grade} from {TotalMarks}");
            }
            else
            {
                Console.WriteLine("No questions found");
            }
        }

        #endregion

    }
}
