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
    public class human_fileBLL : Ihuman_fileBLL
    {
        public Ihuman_fileDao ihf { get; set; }
        public async Task<int> add(M_human_file t)
        {
            return await ihf.add(t);
        }

        public async Task<int> del(M_human_file t)
        {
            return await ihf.del(t);
        }



        public List<human_file> FenYeemr<K>(Expression<Func<human_file, K>> order, Expression<Func<human_file, bool>> where, out int pages, out int rows, int currentPage, int pageSize)
        {
            return ihf.FenYeemr(order, where, out pages, out rows, currentPage, pageSize);
        }

        public List<M_human_file> sel()
        {
            return ihf.sel();
        }

        public List<M_human_file> SelectWhere(Expression<Func<human_file, bool>> where)
        {
            return ihf.SelectWhere(where);
        }

        public int up(M_human_file t, List<string> ps)
        {
            return ihf.up(t,ps);
        }
    }
}
