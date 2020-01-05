using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRModel;
using HRIDAO;
using HRIBLL;
using HREFEntity;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace HRBLL
{
    public class config_file_second_kindBLL : Iconfig_file_second_kindBLL
    {
        public Iconfig_file_second_kindDao icsk { get; set; }
        public Task<List<M_config_file_second_kind>> SelectAllB()
        {
            throw new NotImplementedException();
        }

        public List<M_config_file_second_kind> SelectWhereB(Expression<Func<config_file_second_kind, bool>> where)
        {
            return icsk.SelectWhere(where);
        }

    }
}
