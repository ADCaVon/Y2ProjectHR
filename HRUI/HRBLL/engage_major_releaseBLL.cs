using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRModel;
using HRIDAO;
using HRIBLL;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HREFEntity;

namespace HRBLL
{
    public class engage_major_releaseBLL : Iengage_major_releaseBLL
    {
        public Iengage_major_releaseDao iem { get; set; }
        public Task<int> AddreleaseB(M_engage_major_release emr)
        {
            return iem.Addrelease(emr);
        }

        public Task<int> DeleteEmrB(M_engage_major_release emr)
        {
            return iem.DeleteEmr(emr);
        }

        public List<engage_major_release> FenYeemrB<K>(Expression<Func<engage_major_release, K>> order, Expression<Func<engage_major_release, bool>> where, out int pages, out int rows, int currentPage, int pageSize)
        {
            return iem.FenYeemr(order, where, out pages, out rows, currentPage, pageSize);
        }

        public engage_major_release SelectByIdB(short id)
        {
            return iem.SelectById(id);
        }

        public int updateemrB(M_engage_major_release emr, List<string> ps)
        {
            return iem.updateemr(emr,ps);
        }
    }
}
