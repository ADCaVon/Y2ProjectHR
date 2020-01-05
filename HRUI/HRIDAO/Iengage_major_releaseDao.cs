using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using System.Linq.Expressions;
using HREFEntity;

namespace HRIDAO
{
    public interface Iengage_major_releaseDao
    {
        Task<int> Addrelease(M_engage_major_release emr);//添加
        List<engage_major_release> FenYeemr<K>(Expression<Func<engage_major_release, K>> order, Expression<Func<engage_major_release, bool>> where, out int pages, out int rows, int currentPage, int pageSize);

        engage_major_release SelectById(short id);//根据id查询
        int updateemr(M_engage_major_release emr,List<string> ps);//修改
        Task<int> DeleteEmr(M_engage_major_release emr);//删除
    }
}
