using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HREFEntity;
using HRIDAO;
using HRModel;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace HRDAO
{
    public class engage_interviewDao : DaoBase<engage_interview>, Iengage_interviewDao
    {
        public void ProSel(engage_interview v, M_engage_interview n)
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
        public void ProAdd(engage_interview n, M_engage_interview v)
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
        public Task<int> Addevi(M_engage_interview evi)
        {
            engage_interview ei = new engage_interview();
            ProAdd(ei, evi);
            return Add(ei);
        }

        public int Delsql(string sql)
        {
            throw new NotImplementedException();
        }

        public List<engage_interview> FenYeemr<K>(Expression<Func<engage_interview, K>> order, Expression<Func<engage_interview, bool>> where, out int pages, out int rows, int currentPage, int pageSize)
        {
            return FenYe(order, where, out pages, out rows, currentPage, pageSize).ToList();
        }

        public List<M_engage_interview> selectWehere(Expression<Func<engage_interview, bool>> where)
        {
            List<engage_interview> list = GetWhereNoTK(where);
            List<M_engage_interview> list2 = new List<M_engage_interview>();
            foreach (engage_interview item in list)
            {
                M_engage_interview mei = new M_engage_interview();
                ProSel(item, mei);
                list2.Add(mei);
            }
            return list2;
        }

        public int Updatevi(M_engage_interview evi, List<string> ps)
        {
            engage_interview ei = new engage_interview();
            ProAdd(ei, evi);
            return Update2(ei,ps);
        }
    }
}
