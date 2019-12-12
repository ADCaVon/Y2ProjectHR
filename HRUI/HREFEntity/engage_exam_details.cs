using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class engage_exam_details
    {

        [Key] 
        public System.Int16 exd_id { get; set;}
         
        public System.String exam_number { get; set;}
         
        public System.String first_kind_id { get; set;}
         
        public System.String first_kind_name { get; set;}
         
        public System.String second_kind_id { get; set;}
         
        public System.String second_kind_name { get; set;}
         
        public System.Int16 question_amount { get; set;}
         
    }
}
