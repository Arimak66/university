using Microsoft.AspNetCore.Mvc;
using university.Models;


[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
        [HttpGet()]
        public string GetStudents()
        {
            Student objStudent=new Student();
            string result=objStudent.GetAllStudents();
            return result;

        return "This will return all students.";
        }
        [HttpGet("id")]
        public string GetOneStudent(int id)
        {   Student objStudent=new Student();
            string result=objStudent.GetOneStudent();
            return result;
            return "This will return a student which id ="+id;
        }

        [HttpPost]

        public string AddStudent()
        {
            return "This will add a new student";
        }
        [HttpPut("{id}")]
        
        public string UpdateStudent(int id)
        {
            return "This will update a student which id: "+id;
        }

        [HttpDelete]

        public string DeleteStudent(int id)

        {
            return "Student this will delete a student which id: "+id;
        }


    }
    