using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using HREFEntity;
using System.Linq.Expressions;

namespace HRIDAO
{
    public interface IuserDao
    {
        Task<List<M_users>> selectUser();
        int selectCount(Expression<Func<users, bool>> where);
    }
}
