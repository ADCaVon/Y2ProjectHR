using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class users
    {

        [Key] 
        public System.Int32 u_id { get; set;}
         
        public System.String u_name { get; set;}
         
        public System.String u_true_name { get; set;}
         
        public System.String u_password { get; set;}
         
    }
}
