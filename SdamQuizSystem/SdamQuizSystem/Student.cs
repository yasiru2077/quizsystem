using System;
using System.Collections.Generic;
using System.Text;

namespace SdamQuizSystem
{
    class Student
    {

        public string StName { get; set; }
        private static int StId = 1;

        // Constructor
        public Student(string name)
        {

            StName = name;
            S_id = StId++;

        }
        public int S_id { get; }


    }
}
