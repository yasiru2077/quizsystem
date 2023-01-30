using System;
using System.Collections.Generic;
using System.Text;

namespace SdamQuizSystem
{
    class Teachers
    {
        public string Tname { get; set; }
        private static int T_id = 1;


        public Teachers(string tname)
        {
            Tname = tname;
            tId = T_id++;

        }

        public int tId { get; }
    }
}
