using DomainLayer.Data;
using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IProjectService;

namespace finalProject.Controllers
{
    [Route("")]
    [ApiController]
    public class CreateProjectController : ControllerBase
    {
        private readonly IProjectService<projectModel> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        public CreateProjectController(IProjectService<projectModel> ProjectService, ApplicationDbContext applicationDbContext)
        {
            _customService = ProjectService;
            _applicationDbContext = applicationDbContext;
        }
        [HttpGet(nameof(GetProjectById))]
        public IActionResult GetProjectById(int Id)
        {
            var obj = _customService.Get(Id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllProjectDetails))]
        public IActionResult GetAllProjectDetails()
        {
            var obj = _customService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost(nameof(Create))]
        public IActionResult Create(projectModel project)
        {
            if (project != null)
            {
                _customService.Insert(project);
                return Ok(project);
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPut(nameof(Update))]
        public IActionResult Update(projectModel project)
        {
            if (project != null)
            {
                _customService.Update(project);
                return Ok(project);
            }
            else
            {
                return BadRequest();
            }
        }
       
    }

}

