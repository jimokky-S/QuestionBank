using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuestionModel
    {
        public string QuestionText { get; set; }
        public string DifficultyLevel { get; set; }
        public string QuestionType { get; set; }
        public string Session { get; set; }
        public string grade { get; set; }
        public int LessionID { get; set; }
    }
}
