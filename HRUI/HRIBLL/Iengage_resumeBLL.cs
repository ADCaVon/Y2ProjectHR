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
    public interface Iengage_resumeBLL
    {
        Task<int> Adder(M_engage_resume er);//添加
        List<engage_resume> FenYeemr<K>(Expression<Func<engage_resume, K>> order, Expression<Func<engage_resume, bool>> where, out int pages, out int rows, int currentPage, int pageSize);//分页
        M_engage_resume selectById(short id);//根据ID查
        int Updateer(M_engage_resume er,List<string> ps);//修改
        Task<int> Deleteer(M_engage_resume er);//删除
    }
}
