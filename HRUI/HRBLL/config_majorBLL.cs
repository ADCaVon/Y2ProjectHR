using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRModel;
using HRIDAO;
using HRIBLL;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HREFEntity;

namespace HRBLL
{
    public class config_majorBLL : Iconfig_majorBLL
    {
        public Iconfig_majorDao icmd { get; set; }
        public Task<List<M_config_major>> SelectAllB()
        {
            throw new NotImplementedException();
        }

        public List<M_config_major> SelectWhereB(Expression<Func<config_major, bool>> where)
        {
            return icmd.SelectWhere(where);
        }

   
    }
}
