using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HRModel;
using HREFEntity;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;

namespace HRDAO
{
    public class userDao : DaoBase<users>, IuserDao
    {
        public int selectCount(Expression<Func<users, bool>> where)
        {
            int count = GetCount(where);
            return count;
        }

        public async Task<List<M_users>> selectUser()
        {
            List<users> list = await GetAll();
            List<M_users> list2 = new List<M_users>();
            foreach (users item in list)
            {
                M_users us = new M_users();
                PropertyInfo[] propertys = us.GetType().GetProperties();
                PropertyInfo[] propertys2 = item.GetType().GetProperties();
                object obj = null;
                foreach (PropertyInfo property in propertys2)
                {
                    foreach (PropertyInfo pp in propertys)
                    {
                        if (property.Name == pp.Name)
                        {
                            obj = property.GetValue(item, null);
                            pp.SetValue(us, obj, null);
                            break;
                        }
                    }
               }
                list2.Add(us);
            }

            return list2;
        }
         

        }
    }

         

