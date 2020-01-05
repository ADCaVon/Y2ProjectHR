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
    public class config_file_second_kindDao : DaoBase<config_file_second_kind>, Iconfig_file_second_kindDao
    {
      
        //���� ��Model����
        public void ProSel(config_file_second_kind v,M_config_file_second_kind n)
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
        public Task<List<M_config_file_second_kind>> SelectAll()
        {
            throw new NotImplementedException();
        }
        public List<M_config_file_second_kind> SelectWhere(Expression<Func<config_file_second_kind, bool>> where)
        {
            List<config_file_second_kind> list = GetWhereNoTK(where);
            List<M_config_file_second_kind> list2 = new List<M_config_file_second_kind>();
            foreach(config_file_second_kind item in list)
            {
                M_config_file_second_kind mfsk = new M_config_file_second_kind();
                ProSel(item,mfsk);
                list2.Add(mfsk);
            }
            return list2;
        }
    }
}
