using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HRIBLL;
using HRModel;
using HREFEntity;
using System.Linq.Expressions;

namespace HRBLL
{
    public class engage_interviewBLL : Iengage_interviewBLL
    {
        public Iengage_interviewDao ied { get; set; }
        public Task<int> Addevi(M_engage_interview evi)
        {
            return ied.Addevi(evi);
        }

        public int Delsql(string sql)
        {
            throw new NotImplementedException();
        }

        public List<engage_interview> FenYeemr<K>(Expression<Func<engage_interview, K>> order, Expression<Func<engage_interview, bool>> where, out int pages, out int rows, int currentPage, int pageSize)
        {
            return ied.FenYeemr(order, where, out pages, out rows, currentPage, pageSize);
        }

        public List<M_engage_interview> selectWehere(Expression<Func<engage_interview, bool>> where)
        {
            return ied.selectWehere(where);
        }

        public int Updatevi(M_engage_interview evi, List<string> ps)
        {
            return ied.Updatevi(evi,ps);
        }
    }
}
