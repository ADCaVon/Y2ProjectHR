using HREFEntity;
using HRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRIBLL
{
    public interface Iengage_interviewBLL
    {
        Task<int> Addevi(M_engage_interview evi);//添加
        int Updatevi(M_engage_interview evi, List<string> ps);//修改
        List<engage_interview> FenYeemr<K>(Expression<Func<engage_interview, K>> order, Expression<Func<engage_interview, bool>> where, out int pages, out int rows, int currentPage, int pageSize);//分页
        List<M_engage_interview> selectWehere(Expression<Func<engage_interview, bool>> where);//带条件查询
        int Delsql(string sql);//用sql语句删除
    }
}
