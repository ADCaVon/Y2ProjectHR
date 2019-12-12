using HREFEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRDAO
{
    public class DaoBase<T> where T :class
    {
        //查所有
        HRContext db = new HRContext();

        public async Task<List<T>> GetAll()
        {
            var task = await Task.Run(() => {
                return db.Set<T>()
                  .AsNoTracking()
                  .ToList();
            });
            return task;
        }

        //按条件查询
        public async Task<List<T>> GetWhere(Expression<Func<T, bool>> where)
        {
            var task = await Task.Run(() => {
                return db.Set<T>().AsNoTracking()
                .Where(where)
                .ToList();
            });
            return task;
        }

        //添加
        public async Task<int> Add(T t)
        {

            db.Set<T>().Add(t);
            return await db.SaveChangesAsync();
        }



        //修改
        public int Update(T t, params string[] ps)
        {
            FenLi(t);
            // odb.Detach()

            db.Set<T>().Attach(t);
            // db.Entry(t).State = System.Data.Entity.EntityState.Unchanged;
            foreach (string item in ps)
            {
                db.Entry(t).Property(item).IsModified = true;
            }
            return db.SaveChanges();
        }

        //删除
        public async Task<int> Del(T t)
        {
            FenLi(t);
            db.Set<T>().Attach(t);
            db.Set<T>().Remove(t);
            return await db.SaveChangesAsync();
        }

        private void FenLi(T t)
        {
            var ObjContext = ((IObjectContextAdapter)db).ObjectContext;//第1处
            //2 创建新的 ObjectSet< TEntity > 实例
            var objSet = ObjContext.CreateObjectSet<T>();
            //3 为特定对象创建实体键，如果实体键已存在，则返回该键。
            var objKey = ObjContext.CreateEntityKey(objSet.EntitySet.Name, t);//第2处
            //4 返回具有指定实体键的对象。
            object objT;
            var ext = ObjContext.TryGetObjectByKey(objKey, out objT);
            //5 从对象上下文移除对象。
            if (ext)
            {

                ObjContext.Detach(objT);
            }
        }
    }
}
