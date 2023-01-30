using System;
using System.Collections.Generic;
using System.Text;

namespace SdamQuizSystem
{
    class Question
    {
        public string Questions { get; set; }

        public string[] Answer { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public int Marks { get; set; }
        public Question(string questions, string[] answer, int correctAnswerIndex,int marks)
        {
            Questions = questions;
            Answer = answer;
            CorrectAnswerIndex = correctAnswerIndex;
            Marks = marks;
        }
    }
}
