using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
namespace HRIDAO
{
    public interface IuserDao
    {
        Task<List<M_users>> selectUser();
    }
}
