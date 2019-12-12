using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class config_public_char
    {

        [Key] 
        public System.Int16 pbc_id { get; set;}
         
        public System.String attribute_kind { get; set;}
         
        public System.String attribute_name { get; set;}
         
    }
}
