using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class config_question_first_kind
    {

        [Key] 
        public System.Int16 qfk_id { get; set;}
         
        public System.String first_kind_id { get; set;}
         
        public System.String first_kind_name { get; set;}
         
    }
}
