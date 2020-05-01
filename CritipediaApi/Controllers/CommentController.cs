using CritipediaApi.Filters;
using CritipediaDataAccess;
using CritipediaModels.Mappers;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CritipediaApi.Exceptions
{
    [ApiController]
    public class CommentController : ControllerBase
    {
        private IUnitOfWork _work;
        public CommentController(IUnitOfWork work)
        {
            _work = work;
        }

        [Route("/comment")]
        [HttpGet]
        public IActionResult Get()
        {
            var comments = _work.RepositoryComentarios.GetAll().ToList();

            return Ok(CommentMapper.Map(comments));
        }

        [Route("/comment/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            var comments = _work.RepositoryComentarios.GetById(id);

            return Ok(CommentMapper.Map(comments));
        }

        [Route("/comment/rev/{id}")]
        [HttpGet]
        public IActionResult GetByReview(int id)
        {
            var comments = _work.RepositoryComentarios.GetByCritica(id);

            return Ok(CommentMapper.Map(comments));
        }

        [Route("/comment/paginated/{idRew}/{page}/{rows}")]
        [HttpGet]
        public IActionResult GetPaginatedCrit(int idRew, int page, int rows)
        {
            var comments = _work.RepositoryComentarios.GetPaginated(idRew, page, rows).ToList();

            return Ok(CommentMapper.Map(comments));
        }

        [Route("/comment")]
        [HttpPost]
        public IActionResult Insert(Comentario com)
        {
            if (!ModelState.IsValid)
                throw new System.Exception("Not valid value provid. See documentation");

            return Created(Request.Path.Value, CommentMapper.Map(_work.RepositoryComentarios.Insert(com)));
        }

        [Route("/comment")]
        [HttpDelete]
        public IActionResult Delete(Comentario com)
        {
            if (!ModelState.IsValid)
                throw new System.Exception("Not valid value provid. See documentation");

            _work.RepositoryComentarios.Delete(com);

            return Ok();
        }

        [Route("/comment")]
        [HttpPut]
        public IActionResult Update(Comentario com)
        {
            if (!ModelState.IsValid)
                throw new System.Exception("Not valid value provid. See documentation");

            if (_work.RepositoryComentarios.Update(com))
                return Ok( CommentMapper.Map(com) );
            else
                throw new System.Exception("An fail has ocurred");
        }
    }
}