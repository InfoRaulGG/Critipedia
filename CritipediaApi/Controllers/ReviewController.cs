using CritipediaDataAccess;
using Microsoft.AspNetCore.Mvc;

namespace CritipediaApi.Exceptions
{
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private IUnitOfWork _work;
        public ReviewController(IUnitOfWork work)
        {
            _work = work;
        }

        [Route("/review")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_work.RepositoryCriticas.GetAll());
        }

        [Route("/review/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_work.RepositoryCriticas.GetById(id));
        }
    }
}