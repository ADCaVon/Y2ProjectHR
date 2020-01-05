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
    public interface Iconfig_majorDao
    {
        Task<List<M_config_major>> SelectAll();
        List<M_config_major> SelectWhere(Expression<Func<config_major, bool>> where);//待条件查
    }
}
