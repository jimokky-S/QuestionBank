using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExamModel
    {
        public DateTime DateTimeCreateExam 
        {
            get 
            {
                return DateTime.Now;
            }
            
        }
        public int Duration { get; set; }
        public string Type { get; set; }
        public string Grade { get; set; }
        public float MaxScore { get; set; }
        public DateTime TimeOfHolding { get; set; }
        public int LessionID { get; set; }
        public int LogID { get; set; }

    }
}
