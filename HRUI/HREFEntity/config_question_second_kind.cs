using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class config_question_second_kind
    {

        [Key] 
        public System.Int16 qsk_id { get; set;}
         
        public System.String first_kind_id { get; set;}
         
        public System.String first_kind_name { get; set;}
         
        public System.String second_kind_id { get; set;}
         
        public System.String second_kind_name { get; set;}
         
    }
}
