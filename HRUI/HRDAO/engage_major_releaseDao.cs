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
using System.ComponentModel.DataAnnotations;

namespace HRDAO
{
    public class engage_major_releaseDao : DaoBase<engage_major_release>, Iengage_major_releaseDao
    {
        public void ProSel(engage_major_release v, M_engage_major_release n)
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
        public void ProAdd(engage_major_release n, M_engage_major_release v)
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
        public Task<int> Addrelease(M_engage_major_release emr)
        {
            engage_major_release em = new engage_major_release();
            ProAdd(em,emr);
            return Add(em);
        }

        public Task<int> DeleteEmr(M_engage_major_release emr)
        {
            engage_major_release em = new engage_major_release();
            ProAdd(em, emr);
            return Del(em);
        }

        public List<engage_major_release> FenYeemr<K>(Expression<Func<engage_major_release, K>> order, Expression<Func<engage_major_release, bool>> where, out int pages, out int rows, int currentPage, int pageSize)
        {
            return FenYe(order, where, out pages, out rows, currentPage, pageSize).ToList();
        }

        public engage_major_release SelectById(short id)
        {
            return GetWhereNoTK(e => e.mre_id.Equals(id)).FirstOrDefault();
        }

        public int updateemr(M_engage_major_release emr, List<string> ps)
        {
            engage_major_release em = new engage_major_release();
            ProAdd(em, emr);
            return Update2(em,ps);
        }
    }
}
