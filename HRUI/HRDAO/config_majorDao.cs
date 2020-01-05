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
    public class config_majorDao : DaoBase<config_major>, Iconfig_majorDao
    {
        public void ProSel(config_major v, M_config_major n)
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
        public Task<List<M_config_major>> SelectAll()
        {
            throw new NotImplementedException();
        }
       
        public List<M_config_major> SelectWhere(Expression<Func<config_major, bool>> where)
        {
            List<config_major> list =GetWhereNoTK(where);
            List<M_config_major> list2 = new List<M_config_major>();
            foreach (config_major item in list)
            {
                M_config_major mfsk = new M_config_major();
                ProSel(item, mfsk);
                list2.Add(mfsk);
            }
            return list2;
        }


    }
}
