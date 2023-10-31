using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProject.DAL.Repository {
    public interface IGenericRepository<T> where T: class {
        Task<bool> Insert(T model);

        Task<bool> UpdateOne(T model);

        Task<T> FindOne(int id);
        Task<IQueryable<T>> FindAll();

        Task<bool> DeleteOne(int id);
    }
}
