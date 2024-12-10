using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using RingoMediaProject.DataContext;
using RingoMediaProject.DomainModel.Models;

namespace RingoMediaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly AppDbContext _context;
        public DepartmentController(AppDbContext context)
        {
                _context=context;
        }
        [HttpPost("AddDepartment")]
        public IActionResult AddDepartment([FromBody] Department department)
        {
            if(department != null) 
            {
                var isDeptExist = _context.departments.FirstOrDefault(u => u.Dept_Name.ToLower() == department.Dept_Name.ToLower());
                if(isDeptExist == null)
                {
                    var addDepartment = _context.departments.Add(department);
                    _context.SaveChanges();
                    return Ok(_context.departments.FirstOrDefault(u => u.Dept_Name.ToLower() == department.Dept_Name.ToLower()));
                }
            }
            return BadRequest();
        }
        [HttpGet("GetAllSubDept")]
        //[Route("{dept:string}")]
        public IActionResult GetAllSubDept(string dept)
        {
            var deptList = new List<Department>();
            var isDeptExist = _context.departments.FirstOrDefault(u => u.Dept_Name.ToLower() == dept.ToLower());
            deptList.Add(isDeptExist);
            if(dept== null || isDeptExist==null)
            {
                return BadRequest(new { Message = "Department not found!"});
            }
            var subDept = _context.departments.Where(u => u.Dept_Parent_Id == isDeptExist.Dept_Id);
            deptList.AddRange(subDept);            
            
            return Ok(deptList);
        }
        [HttpGet("GetAllPerentDept")]
        public IActionResult GetAllPerentDept(string dept)
        {
            var deptList = new List<Department>();
            var isDeptExist = _context.departments.FirstOrDefault(u => u.Dept_Name.ToLower() == dept.ToLower());
            if (dept == null || isDeptExist == null)
            {
                return BadRequest(new { Message = "Department not found!" });
            }
            deptList.Add(isDeptExist);
            while(isDeptExist.Dept_Parent_Id!=0)
            {
                isDeptExist = _context.departments.FirstOrDefault(u=>u.Dept_Id == isDeptExist.Dept_Parent_Id);
                deptList.Add(isDeptExist);
            }
            return Ok(deptList);
        }
    }
}
