using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class config_major_kind
    {

        [Key] 
        public System.Int16 mfk_id { get; set;}
         
        public System.String major_kind_id { get; set;}
         
        public System.String major_kind_name { get; set;}
         
    }
}
