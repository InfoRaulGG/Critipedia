using CritipediaDataAccess;
using CritipediaDataAccess.Repositories;
using Entities;
using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Test
{
    public class CommentService
    {
        private readonly Mock<IRepositoryComentarios> _mock;
        private readonly IRepositoryComentarios _mockRepo;
        public CommentService()
        {
            var comentarios = new List<Comentario>
            {
                new Comentario { Id = 1, Descripcion = "ASDA", Fecha = DateTime.Now, Nota = 5, CriticaId = 1, UserId = 1 },
                new Comentario { Id = 2, Descripcion = "ASDA", Fecha = DateTime.Now, Nota = 5, CriticaId = 2, UserId = 1 },
                new Comentario { Id = 3, Descripcion = "ASDA", Fecha = DateTime.Now, Nota = 5, CriticaId = 5, UserId = 1 },
                new Comentario { Id = 4, Descripcion = "ASDA", Fecha = DateTime.Now, Nota = 5, CriticaId = 2, UserId = 1 },
                new Comentario { Id = 5, Descripcion = "ASDA", Fecha = DateTime.Now, Nota = 5, CriticaId = 3, UserId = 1 }
            };

            _mock = new Mock<IRepositoryComentarios>();
            _mock.Setup(x => x.GetAll()).Returns(comentarios);
            _mock.Setup(x => x.GetById(It.IsAny<int>())).Returns((int i) => comentarios.Where(x => x.Id == i).Single());
            _mock.Setup(x => x.GetByCritica(It.IsAny<int>())).Returns((int i) => comentarios.Where(x => x.CriticaId == i));
            _mock.Setup(x => x.GetPaginated(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).Returns((int i, int x, int j) => comentarios.Where(x => x.CriticaId == i).ToList().Skip((x - 1) * j).Take(j).ToList());

            _mockRepo = _mock.Object;
        }


        [Fact]
        public void GetAll()
        {
            IEnumerable<Comentario> canList = _mockRepo.GetAll();

            Assert.NotNull(canList);
            Assert.True(canList is IEnumerable<Comentario>);
            Assert.True(canList.Count() == 5);
        }

        [Fact]
        public void GetById()
        {
            Comentario canId = _mockRepo.GetById(2);

            Assert.NotNull(canId);
            Assert.True(canId is Comentario);
            Assert.Equal(2, canId.Id);
        }

        [Fact]
        public void GetByCritica()
        {
            IEnumerable<Comentario> canCritica = _mockRepo.GetByCritica(2);

            Assert.NotNull(canCritica);
            Assert.True(canCritica is IEnumerable<Comentario>);
            Assert.True(canCritica.All(x => x.CriticaId == 2));
            Assert.True(canCritica.Count() == 2);
        }


        [Fact]
        public void GetPaginated()
        {
            IEnumerable<Comentario> canCriticaPaginated = _mockRepo.GetPaginated(2, 2, 1);

            Assert.NotNull(canCriticaPaginated);
            Assert.True(canCriticaPaginated is IEnumerable<Comentario>);
            Assert.True(canCriticaPaginated.All(x => x.CriticaId == 2));
            Assert.True(canCriticaPaginated.Count() == 1);

            Assert.Equal(4, canCriticaPaginated.FirstOrDefault().Id);
        }

     
    }
}
