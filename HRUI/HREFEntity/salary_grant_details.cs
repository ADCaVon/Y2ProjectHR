using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class salary_grant_details
    {

        [Key] 
        public System.Int16 grd_id { get; set;}
         
        public System.String salary_grant_id { get; set;}
         
        public System.String human_id { get; set;}
         
        public System.String human_name { get; set;}
         
        public System.Decimal bouns_sum { get; set;}
         
        public System.Decimal sale_sum { get; set;}
         
        public System.Decimal deduct_sum { get; set;}
         
        public System.Decimal salary_standard_sum { get; set;}
         
        public System.Decimal salary_paid_sum { get; set;}
         
    }
}
