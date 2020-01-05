using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HREFEntity;
using System.Linq.Expressions;

namespace HRDAO
{
    public class config_public_charDao : DaoBase<config_public_char>, Iconfig_public_charDao
    {
        public List<config_public_char> selbyWhere(Expression<Func<config_public_char, bool>> where)
        {
            return GetWhereNoTK(where);
        }
    }
}
