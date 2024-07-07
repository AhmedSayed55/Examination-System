using Exam_2.exam;
using Exam_2.qustion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2.subject
{
    internal class Subject
    {
        #region constructors
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        #endregion


        #region properties and methods
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        #endregion


        #region methods
        public void CreateExam()
        {
            bool flag1;
            int type, time, numberOfQuestions;
            do
            {
                Console.WriteLine("please enter the type of the exam you want (1 for practical 2 for final):");
                flag1 = int.TryParse(Console.ReadLine(), out type);
            } while (!flag1 || (type < 1 || type > 2));

            bool flag2;
            do
            {
                Console.WriteLine("enter the time of the exam in minuets:");
                flag2 = int.TryParse(Console.ReadLine(), out time);
            } while (!flag2 || time <=0);

            bool flag3;
            do
            {
                Console.WriteLine("enter the number of questions you wanted to create:");
                flag3 = int.TryParse(Console.ReadLine(), out numberOfQuestions);
            } while (!flag3 || numberOfQuestions <= 0);

            if (type == 1)
            {
                Exam = new PracticalExam(time, numberOfQuestions);
                Exam.ExamQuestions = new MCQ[Exam.NumberOfQuestions];
                for (int i = 0; i < Exam.ExamQuestions.Length; i++)
                {
                    Exam.ExamQuestions[i] = new MCQ();
                    Exam.ExamQuestions[i].CreateQuestion();
                    Console.WriteLine("====================================");
                }
            }
            else
            {
                Exam = new FinalExam(time, numberOfQuestions);
                Exam.ExamQuestions = new Question[Exam.NumberOfQuestions];
                for (int i = 0; i < Exam.ExamQuestions.Length; i++)
                {
                    bool flag;
                    int x;
                    do
                    {
                        Console.WriteLine($"please choose the type of question Number {i + 1} (1 for true|false 2 for MCQ )");
                        flag = int.TryParse(Console.ReadLine(), out x);
                    } while (!flag || (x < 1 || x > 2));

                    if (x == 1)
                    {
                        Exam.ExamQuestions[i] = new TrueOrFalse();
                        Exam.ExamQuestions[i].CreateQuestion();
                    }
                    else if (x == 2)
                    {
                        Exam.ExamQuestions[i] = new MCQ();
                        Exam.ExamQuestions[i].CreateQuestion();
                    }
                    Console.WriteLine("====================================");
                }
            }
        }
        #endregion

    }
}
