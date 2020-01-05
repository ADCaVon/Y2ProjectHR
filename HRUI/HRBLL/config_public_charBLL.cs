using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIBLL;
using HRIDAO;
using HREFEntity;
using System.Linq.Expressions;

namespace HRBLL
{
    public class config_public_charBLL : Iconfig_public_charBLL
    {
        public Iconfig_public_charDao icpd { get; set; }
        public List<config_public_char> SelbyWhere(Expression<Func<config_public_char, bool>> where)
        {
            return icpd.selbyWhere(where);
        }
    }
}
