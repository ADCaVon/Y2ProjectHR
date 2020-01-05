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
    public interface Iconfig_file_first_kindBLL
    {
        Task<List<M_config_file_first_kind>> SelectAll();
        List<M_config_file_first_kind> SelectWhereB(Expression<Func<config_file_first_kind, bool>> where);//待条件查
    }
}
