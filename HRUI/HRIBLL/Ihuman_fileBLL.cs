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
    public interface Ihuman_fileBLL
    {
        List<human_file> FenYeemr<K>(Expression<Func<human_file, K>> order, Expression<Func<human_file, bool>> where, out int pages, out int rows, int currentPage, int pageSize);//分页
        List<M_human_file> sel();
        Task<int> add(M_human_file t);
        List<M_human_file> SelectWhere(Expression<Func<human_file, bool>> where);
        int up(M_human_file t, List<string> ps);

        Task<int> del(M_human_file t);
    }
}
