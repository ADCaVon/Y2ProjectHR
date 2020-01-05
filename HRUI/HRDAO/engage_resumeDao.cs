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
    public class engage_resumeDao : DaoBase<engage_resume>, Iengage_resumeDao
    {
        public void ProSel(engage_resume v, M_engage_resume n)
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
        public void ProAdd(engage_resume n, M_engage_resume v)
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
        public Task<int> Adder(M_engage_resume er)
        {
            engage_resume em = new engage_resume();
            ProAdd(em, er);
            return Add(em);
        }

        public List<engage_resume> FenYeemr<K>(Expression<Func<engage_resume, K>> order, Expression<Func<engage_resume, bool>> where, out int pages, out int rows, int currentPage, int pageSize)
        {
            return FenYe(order, where, out pages, out rows, currentPage, pageSize).ToList();
        }

        public M_engage_resume selectById(short id)
        {
            engage_resume er = new engage_resume();
            M_engage_resume mer = new M_engage_resume();
            er= GetWhereNoTK(e => e.res_id.Equals(id)).FirstOrDefault();
            ProSel(er,mer);
            return mer;
        }

        public int Updateer(M_engage_resume er, List<string> ps)
        {
            engage_resume em = new engage_resume();
            ProAdd(em, er);
            return Update2(em, ps);
        }

        public Task<int> Deleteer(M_engage_resume er)
        {
            engage_resume erm = new engage_resume();
            ProAdd(erm, er);
            return Del(erm);
        }
    }
}
