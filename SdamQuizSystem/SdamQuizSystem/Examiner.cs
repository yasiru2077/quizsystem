using System;
using System.Collections.Generic;
using System.Text;

namespace SdamQuizSystem
{
    class Examiner
    {

        public string Ename { get; set; }
        private static int E_id = 1;

        public Examiner(string ename)
        {

            ename = Ename;
            eId = E_id++;

        }

        public int eId { get; }

    }
}
