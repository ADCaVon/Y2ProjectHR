using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRModel;
using HRIDAO;
using HRIBLL;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HREFEntity;

namespace HRBLL
{
    public class config_major_kindBLL : Iconfig_major_kindBLL
    {
        public Iconfig_major_kindDao icmk { get; set; }
        public Task<List<M_config_major_kind>> SelectAllB()
        {
            return icmk.SelectAll();
        }

        public List<M_config_major_kind> SelectWhereB(Expression<Func<config_major_kind, bool>> where)
        {
            return icmk.SelectWhere(where);
        }
    }
}
