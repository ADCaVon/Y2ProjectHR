using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using System.Linq.Expressions;
using HREFEntity;

namespace HRIDAO
{
    public interface Iconfig_file_third_kindDao
    {
        Task<List<M_config_file_third_kind>> SelectAll();
        List<M_config_file_third_kind> SelectWhere(Expression<Func<config_file_third_kind, bool>> where);//待条件查
    }
}
