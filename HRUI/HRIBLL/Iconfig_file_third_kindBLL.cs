using HREFEntity;
using HRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRIBLL
{
    public interface Iconfig_file_third_kindBLL
    {
        Task<List<M_config_file_third_kind>> SelectAllB();
        List<M_config_file_third_kind> SelectWhereB(Expression<Func<config_file_third_kind, bool>> where);//待条件查
    }
}
