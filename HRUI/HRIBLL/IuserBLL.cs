using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using HREFEntity;
using System.Linq.Expressions;

namespace HRIBLL
{
    public interface IuserBLL
    {
        Task<List<M_users>> SelectUser();
    }
}
