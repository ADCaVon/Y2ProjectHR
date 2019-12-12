using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class config_primary_key
    {

        [Key] 
        public System.Int16 prk_id { get; set;}
         
        public System.String primary_key_table { get; set;}
         
        public System.String primary_key { get; set;}
         
        public System.String key_name { get; set;}
         
        public System.Boolean primary_key_status { get; set;}
         
    }
}
