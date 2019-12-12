using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class engage_answer_details
    {

        [Key] 
        public System.Int16 and_id { get; set;}
         
        public System.String answer_number { get; set;}
         
        public System.Int16 subject_id { get; set;}
         
        public System.String answer { get; set;}
         
    }
}
