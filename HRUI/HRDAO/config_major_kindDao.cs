using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRIDAO;
using HRModel;
using HREFEntity;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Reflection;

namespace HRDAO
{
    public class config_major_kindDao : DaoBase<config_major_kind>, Iconfig_major_kindDao
    {
        public void ProSel(config_major_kind v, M_config_major_kind n)
        {
            PropertyInfo[] propertys = n.GetType().GetProperties();
            PropertyInfo[] propertys2 = v.GetType().GetProperties();
            object obj = null;
            foreach (PropertyInfo property in propertys2)
            {
                foreach (PropertyInfo pp in propertys)
                {
                    if (property.Name == pp.Name)
                    {
                        obj = property.GetValue(v, null);
                        pp.SetValue(n, obj, null);
                        break;
                    }
                }
            }
        }
        public async Task<List<M_config_major_kind>> SelectAll()
        {
            List<config_major_kind> list = await GetAll();
            List<M_config_major_kind> list2 = new List<M_config_major_kind>();
            foreach (config_major_kind item in list)
            {
                M_config_major_kind cmk = new M_config_major_kind();
                ProSel(item,cmk);
                list2.Add(cmk);
            }
            return list2;
        }

        public List<M_config_major_kind> SelectWhere(Expression<Func<config_major_kind, bool>> where)
        {
            List<config_major_kind> list =GetWhereNoTK(where);
            List<M_config_major_kind> list2 = new List<M_config_major_kind>();
            foreach (config_major_kind item in list)
            {
                M_config_major_kind cmk = new M_config_major_kind();
                ProSel(item, cmk);
                list2.Add(cmk);
            }
            return list2;
        }
    }
}
