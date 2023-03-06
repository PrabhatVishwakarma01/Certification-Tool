using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Tool.Shared
{
    public class AddQuestionDto
    {
        public int QuestionIID
        {
            get;
            set;
        }




        public string QuestionName
        {
            get;
            set;
        }

        public string Option1
        {
            get;
            set;
        }
        public string Option2
        {
            get;
            set;
        }
        public string Option3
        {
            get;
            set;
        }
        public string Option4
        {
            get;
            set;
        }



    }
}