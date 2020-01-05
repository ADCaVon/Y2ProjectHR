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
    public interface Iconfig_majorBLL
    {
        Task<List<M_config_major>> SelectAllB();
        List<M_config_major> SelectWhereB(Expression<Func<config_major, bool>> where);//待条件查
    }
}
