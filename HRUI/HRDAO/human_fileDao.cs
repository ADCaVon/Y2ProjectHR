using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HRModel;
using HREFEntity;
using System.Linq.Expressions;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace HRDAO
{
    public class human_fileDao : DaoBase<human_file>, Ihuman_fileDao
    {
        public void ProSel(human_file v, M_human_file n)
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
        public void ProAdd(human_file n, M_human_file v)
        {
            PropertyInfo[] propertys = n.GetType().GetProperties();
            PropertyInfo[] propertys2 = v.GetType().GetProperties();
            PropertyInfo pkProp = typeof(engage_major_release).GetProperties().Where(p => p.GetCustomAttributes(typeof(KeyAttribute), false).Length > 0).FirstOrDefault();
            object obj = null;
            foreach (PropertyInfo property in propertys2)
            {
                foreach (PropertyInfo pp in propertys)
                {
                    if (property.GetValue(v, null) != null)
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
        }
        public async Task<int> add(M_human_file t)
        {
            human_file hf = new human_file();
            ProAdd(hf, t);
            return await Add(hf);
        }

        public async Task<int> del(M_human_file t)
        {
            human_file hf = new human_file();
            ProAdd(hf, t);
            return await Del(hf);
        }

        public List<human_file> FenYeemr<K>(Expression<Func<human_file, K>> order, Expression<Func<human_file, bool>> where, out int pages, out int rows, int currentPage, int pageSize)
        {
            return FenYe(order, where, out pages, out rows, currentPage, pageSize).ToList();
        }

        public List<M_human_file> sel()
        {
            List<human_file> list = GetAll2();
            List<M_human_file> list2 = new List<M_human_file>();
            foreach (human_file item in list)
            {
                M_human_file cfk = new M_human_file();
                ProSel(item, cfk);
                list2.Add(cfk);
            }
            return list2;
        }

        public List<M_human_file> SelectWhere(Expression<Func<human_file, bool>> where)
        {
            List<human_file> list = GetWhereNoTK(where);
            List<M_human_file> list2 = new List<M_human_file>();
            foreach (human_file item in list)
            {
                M_human_file hr = new M_human_file();
                ProSel(item, hr);
                list2.Add(hr);
            }
            return list2;
        }

        public int up(M_human_file t,List<string> ps)
        {
            human_file hr = new human_file();
            ProAdd(hr, t);
            return Update2(hr, ps);
        }
    }
}
