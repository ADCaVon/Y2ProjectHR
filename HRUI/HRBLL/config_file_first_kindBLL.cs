using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRModel;
using HRIDAO;
using HRIBLL;
using System.Threading.Tasks;
using HREFEntity;
using System.Linq.Expressions;

namespace HRBLL
{
    public class config_file_first_kindBLL : Iconfig_file_first_kindBLL
    {
        public Iconfig_file_first_kindDao icfk { get; set; }
        public Task<List<M_config_file_first_kind>> SelectAll()
        {
           return icfk.SelectAll();
        }

        public List<M_config_file_first_kind> SelectWhereB(Expression<Func<config_file_first_kind, bool>> where)
        {
            return icfk.SelectWhere(where);
        }

      
    }
}
