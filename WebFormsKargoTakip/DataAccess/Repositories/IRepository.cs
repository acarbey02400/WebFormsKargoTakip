using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebFormsKargoTakip.Model.Common;

namespace WebFormsKargoTakip.DataAccess.Repositories
{
    public interface IRepository<T> where T : BaseEntity,new()
    {
        T Add(T t);
        T Update(T t);
        bool Delete(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
    }
}
