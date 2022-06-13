using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamModel
{
   public class Exam_inh : Exam
    {
        public int percent { get; set; } // процент двоек
        public override double Q()
        {
            return base.Q() * (100 - percent) / 100;
        }
        public Exam_inh(string s, int c1, int c2, int p) : base(s, c1, c2)
        {
            percent = p;
        }
        public override string print()
        {
            return base.print() + $" процент двоек - {percent}";
        }

    }
}
