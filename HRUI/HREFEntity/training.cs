using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HREFEntity
{
public class training
    {

        [Key] 
        public System.Int16 tra_id { get; set;}
         
        public System.String major_kind_id { get; set;}
         
        public System.String major_kind_name { get; set;}
         
        public System.String major_id { get; set;}
         
        public System.String major_name { get; set;}
         
        public System.String human_id { get; set;}
         
        public System.String human_name { get; set;}
         
        public System.String training_item { get; set;}
         
        public System.DateTime training_time { get; set;}
         
        public System.Int32 training_hour { get; set;}
         
        public System.String training_degree { get; set;}
         
        public System.String register { get; set;}
         
        public System.String checker { get; set;}
         
        public System.DateTime regist_time { get; set;}
         
        public System.DateTime check_time { get; set;}
         
        public System.Int16 checkstatus { get; set;}
         
        public System.String remark { get; set;}
         
    }
}
