using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {



        private readonly SchoolApiContext context;

        public CourseController(SchoolApiContext context)
        {
           this.context = context;
        }


        [HttpGet(Name = "courses")]
        public IEnumerable<Course> getCourses()
        {

            return this.context.Courses.ToList();

        }
    }
}