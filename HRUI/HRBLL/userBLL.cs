using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using HRIDAO;
using HRIBLL;
namespace HRBLL
{
    public class userBLL : IuserBLL
    {
       public IuserDao iud { get; set; }
        public Task<List<M_users>> SelectUser()
        {
            return iud.selectUser();
        }
    }
}
