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
    public class config_file_third_kindBLL : Iconfig_file_third_kindBLL
    {
        public Iconfig_file_third_kindDao iftk { get; set; }
        public Task<List<M_config_file_third_kind>> SelectAllB()
        {
            throw new NotImplementedException();
        }

        public List<M_config_file_third_kind> SelectWhereB(Expression<Func<config_file_third_kind, bool>> where)
        {
            return iftk.SelectWhere(where);
        }
    }
}
