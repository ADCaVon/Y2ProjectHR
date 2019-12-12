using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class salary_standard_details
    {

        [Key] 
        public System.Int16 sdt_id { get; set;}
         
        public System.String standard_id { get; set;}
         
        public System.String standard_name { get; set;}
         
        public System.Int16 item_id { get; set;}
         
        public System.String item_name { get; set;}
         
        public System.Decimal salary { get; set;}
         
    }
}
