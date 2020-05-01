using CritipediaDataAccess;
using Entities;
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

        [Route("/review/last")]
        [HttpGet]
        public IActionResult GetLast()
        {
            return Ok(_work.RepositoryCriticas.GetLastFive());
        }

        [Route("/review/top/{category}")]
        [HttpGet]
        public IActionResult GetTop(int category)
        {
            return Ok(_work.RepositoryCriticas.GetTopFiveCategory(category));
        }

        [Route("/review")]
        [HttpPost]
        public IActionResult Insert(Critica crit)
        {
            if (!ModelState.IsValid)
                throw new System.Exception("Not valid value provid. See documentation");

            return Ok(_work.RepositoryCriticas.Insert(crit));
        }

        [Route("/review")]
        [HttpDelete]
        public IActionResult Delete(Critica crit)
        {
            if (!ModelState.IsValid)
                throw new System.Exception("Not valid value provid. See documentation");

            if(_work.RepositoryCriticas.GetById(crit.Id) != crit)
                throw new System.Exception("Provided model not match with recorded");

            return Ok(_work.RepositoryCriticas.Delete(crit));
        }

        [Route("/review")]
        [HttpPut]
        public IActionResult Update(Critica crit)
        {
            if (!ModelState.IsValid)
                throw new System.Exception("Not valid value provid. See documentation");


            return Ok(_work.RepositoryCriticas.Update(crit));
        }
    }
}