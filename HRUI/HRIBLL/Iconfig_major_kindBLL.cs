using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using System.Linq.Expressions;
using HREFEntity;

namespace HRIBLL
{
    public interface Iconfig_major_kindBLL
    {
        Task<List<M_config_major_kind>> SelectAllB();
        List<M_config_major_kind> SelectWhereB(Expression<Func<config_major_kind, bool>> where);//待条件查
    }
}
