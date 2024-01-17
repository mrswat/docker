using DockerTest.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DockerTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DockerController : Controller
    {
        private readonly DockerDbContext _dbContext;

        public DockerController(DockerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("imagenames")]
        public IActionResult GetImageNamegs()
        {
            var imageNames = _dbContext.DockerImages.Select(x => x.Name).ToList();

            return Ok(imageNames);
        }
    }
}
