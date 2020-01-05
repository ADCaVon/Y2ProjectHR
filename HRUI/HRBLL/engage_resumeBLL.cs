using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HRIBLL;
using HREFEntity;
using HRModel;
using System.Linq.Expressions;

namespace HRBLL
{
    public class engage_resumeBLL : Iengage_resumeBLL
    {
        public Iengage_resumeDao ierd { get; set; }
        public Task<int> Adder(M_engage_resume er)
        {
            return ierd.Adder(er);
        }

        public Task<int> Deleteer(M_engage_resume er)
        {
            throw new NotImplementedException();
        }

        public List<engage_resume> FenYeemr<K>(Expression<Func<engage_resume, K>> order, Expression<Func<engage_resume, bool>> where, out int pages, out int rows, int currentPage, int pageSize)
        {
            return ierd.FenYeemr(order, where, out pages, out rows, currentPage, pageSize);
        }

        public M_engage_resume selectById(short id)
        {
            return ierd.selectById(id);
        }

        public int Updateer(M_engage_resume er, List<string> ps)
        {
            return ierd.Updateer(er,ps);
        }
    }
}
