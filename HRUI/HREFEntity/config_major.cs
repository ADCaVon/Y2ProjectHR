using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class config_major
    {

        [Key] 
        public System.Int16 mak_id { get; set;}
         
        public System.String major_kind_id { get; set;}
         
        public System.String major_kind_name { get; set;}
         
        public System.String major_id { get; set;}
         
        public System.String major_name { get; set;}
         
        public System.Int16 test_amount { get; set;}
         
    }
}
