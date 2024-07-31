using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TestQuestionsModel
    {
        [Required(ErrorMessage = "Please fill in the test Questions")]
        public int QuestionDetailsID { get; set; }


        [Required(ErrorMessage = "Please fill in the Text test Questions")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Please fill in the Priority")]
        [MinLength(1 , ErrorMessage = "Please choose from 1 to 4")]
        [MaxLength(4 , ErrorMessage = "Please choose from 1 to 4")]
        public int Priority { get; set; }
    }
}
