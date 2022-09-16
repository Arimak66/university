using Microsoft.AspNetCore.Mvc;

namespace university.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
        [HttpGet()]
        public string GetAllTeachers()
        {

        return "This will return all teachers.";
        }
        [HttpGet("id")]
        public string GetOneTeacher(int id)
        {
            return "This will return a teacher which id ="+id;
        }

        [HttpPost]

        public string AddTeacher()
        {
            return "This will add a new teacher";
        }
        [HttpPut("{id}")]
        
        public string UpdateTeacher(int id)
        {
            return "This will update a teacher which id: "+id;
        }

        [HttpDelete]

        public string DeleteTeacher(int id)

        {
            return "This will delete a teacher which id: "+id;
        }


    }
    