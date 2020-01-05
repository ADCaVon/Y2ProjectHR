using HREFEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRIBLL
{
    public interface Iconfig_public_charBLL
    {
        List<config_public_char> SelbyWhere(Expression<Func<config_public_char, bool>> where);
    }
}
