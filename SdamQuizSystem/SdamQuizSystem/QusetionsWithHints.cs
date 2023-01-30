using System;
using System.Collections.Generic;
using System.Text;

namespace SdamQuizSystem
{
    class QusetionsWithHints
    {
        public string Questions { get; set; }

        public string Hint { get; set; }

        public string[] Answer { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public QusetionsWithHints(string questions, string hint, string[] answer, int correctAnswerIndex)
        {
            Questions = questions;
            Answer = answer;
            CorrectAnswerIndex = correctAnswerIndex;
            Hint = hint;
        }
    }
}
