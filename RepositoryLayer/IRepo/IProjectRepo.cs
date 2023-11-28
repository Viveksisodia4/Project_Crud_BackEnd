using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Model;


namespace RepositoryLayer.IProjectRepo
{
    public interface IProjectRepo<T> where T: projectModel
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        void Insert(T entity);
        void Update(T entity);
       

        void SaveChanges();
    }
}
