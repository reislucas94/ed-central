using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EdCentral.Domain;
using EdCentral.Application.Interfaces;

namespace EdCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseAppService _courseAppService;
        public CourseController(ICourseAppService courseAppService) {
            _courseAppService = courseAppService;
        }

        [HttpPut]
        private async Task<IActionResult> Create([FromBody] Course course)
        {
            await _courseAppService.Create(course);

            return Ok();
        }

        [HttpPost]
        private async Task<IActionResult> Edit([FromBody] Course course)
        {
            await _courseAppService.Update(course);

            return Ok();
        }

        [HttpGet]
        private async Task<IActionResult> GetAll()
        {
            await _courseAppService.GetAll();

            return Ok();
        }

        [HttpDelete]
        private async Task<IActionResult> Delete([FromBody] Course course)
        {
            await _courseAppService.Delete(course);

            return Ok();
        }
    }
}