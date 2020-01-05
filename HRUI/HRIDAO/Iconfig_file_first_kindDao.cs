using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using HREFEntity;

namespace HRIDAO
{
    public interface Iconfig_file_first_kindDao
    {
        Task<List<M_config_file_first_kind>> SelectAll();
        List<M_config_file_first_kind> SelectWhere(Expression<Func<config_file_first_kind, bool>> where);//待条件查
    }
}
