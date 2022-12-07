using Microsoft.AspNetCore.Mvc;
using POS.Aplication.Interfaces;
using POS.Infrastructure.Commons.Bases.Request;

namespace POS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryAplication _categoryApplication;

        public CategoryController(ICategoryAplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }
        [HttpPost]
        public async Task<IActionResult> ListCategories([FromBody] BaseFiltersRequest filters)
        {
            var response = await _categoryApplication.ListCategories(filters);
            return Ok(response);

        }

    }


}
