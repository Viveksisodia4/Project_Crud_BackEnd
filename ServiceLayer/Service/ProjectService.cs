using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Model;
using RepositoryLayer.IProjectRepo;
using ServiceLayer.IProjectService;

namespace ServiceLayer.ProjectService
{
    public class ProjectService : IProjectService<projectModel>
    {
        private readonly IProjectRepo<projectModel> _projectRepository;
        public ProjectService(IProjectRepo<projectModel> ProjectRepo)
        {
            _projectRepository = ProjectRepo;
        }
   
        public projectModel Get(int Id)
        {
            try
            {
                var obj = _projectRepository.Get(Id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<projectModel> GetAll()
        {
            try
            {
                var obj = _projectRepository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Insert(projectModel entity)
        {
            try
            {
                if (entity != null)
                {
                    _projectRepository.Insert(entity);
                    _projectRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(projectModel entity)
        {
            try
            {
                if (entity != null)
                {
                    _projectRepository.Update(entity);
                    _projectRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}