using BlogsAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogRepo _blogRepo;

        public BlogsController(IBlogRepo blogRepo)
        {
            _blogRepo = blogRepo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_blogRepo.GetAll());

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           var blog = _blogRepo.Get(id);    
            if(blog == null)
            return NotFound();
            return Ok(blog);    

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var delBlog = _blogRepo.Delete(id);
            if (delBlog == 0)
                return NotFound();
            return NoContent();

        }
    }
}
