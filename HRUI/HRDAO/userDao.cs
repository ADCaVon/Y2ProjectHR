using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HRModel;
using HREFEntity;
namespace HRDAO
{
    public class userDao : DaoBase<users>, IuserDao
    {
        public async Task<List<M_users>> selectUser()
        {
            List<users> list = await GetAll();
            List<M_users> list2 = new List<M_users>();
            foreach (users item in list)
            {
               M_users us = new M_users()
                {
                    u_id = item.u_id,
                    u_name= item.u_name
                };
                list2.Add(us);
            }
            return list2;
        }
    }
}
