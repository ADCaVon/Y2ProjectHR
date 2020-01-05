using HREFEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRIDAO
{
    public interface Iconfig_public_charDao
    {
        List<config_public_char> selbyWhere(Expression<Func<config_public_char, bool>> where);
    }
}
