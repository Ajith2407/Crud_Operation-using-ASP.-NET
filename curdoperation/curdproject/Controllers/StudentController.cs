using curdproject.Db;
using curdproject.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace curdproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        [Route("create")]
        public IActionResult create([FromBody]Student s1) 
        {
            _db.Add(s1);
            _db.SaveChanges();
            return Ok(s1);

        }
        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAll() 
        {
            List<Student> students = new List<Student>();
            students=_db.students.ToList();
            return Ok (students);   
        }
        [HttpGet]
        [Route("GetById")]
        public IActionResult Get(int id)
        {
            Student s1 =_db.students.FirstOrDefault(x => x.Id == id);  
            return Ok(s1);
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Student s1)
        {
            _db.Update(s1);
            _db.SaveChanges();
            return Ok(s1);
        }

        [HttpDelete]
        [Route("Delete")]

        public IActionResult Delete(int id)
        {
            Student s1 = _db.students.FirstOrDefault(x => x.Id == id);
            _db.Remove(s1);
            _db.SaveChanges();
            return Ok(s1);

        }
         
       
        
    }

}
