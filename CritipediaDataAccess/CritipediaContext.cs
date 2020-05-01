using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CritipediaDataAccess
{
    public class CritipediaContext : DbContext
    {
        public DbSet<Critica> Criticas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Subcategoria> Subcategorias { get; set; }
        public DbSet<PasswordReset> PasswordResets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Critipedia;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Random rnd = new Random();
            var db = new CritipediaContext();

            for (var i = 0; i < 300; i++)
            {
                builder.Entity<User>().HasData(
                    new User
                    {
                        Id = i + 1,
                        Nombre = i % 2 == 0 ? "Male" + (i + 1) : "Female" + (i + 1),
                        Apellidos = MockService.GenerateRandomString(rnd.Next(10)) + " " + MockService.GenerateRandomString(rnd.Next(10)),
                        Edad = rnd.Next(75) + 1,
                        Telefono = 666666666,
                        LoginName = MockService.GenerateRandomString(rnd.Next(10)),
                        Password = MockService.GenerateRandomString(rnd.Next(50)),
                        Email = MockService.GenerateRandomString(rnd.Next(25)) + "@gmail.com"
                    }
                );
            }


            for (var i = 0; i < 4; i++)
            {
                builder.Entity<Categoria>().HasData(
                    new Categoria
                    {
                        Id = i + 1,
                        Nombre = MockService.GenerateRandomString(rnd.Next(10)),
                    }
                );
            }

            int countPk = 1;
            for (var i = 0; i < 4; i++)
            {
                for (var k = 0; k < 15; k++)
                {
                    builder.Entity<Subcategoria>().HasData(
                       new Subcategoria
                       {
                           Id = countPk,
                           Nombre = MockService.GenerateRandomString(rnd.Next(10)),
                           CategoriaId = i + 1,
                       }
                    );
                    countPk++;
                }
            }

            for (var i = 0; i < 1500; i++)
            {
                builder.Entity<Critica>().HasData(
                  new Critica
                  {
                      Id = i + 1,
                      Titulo = MockService.GenerateRandomString(rnd.Next(50)),
                      Descripcion = MockService.GenerateRandomString(rnd.Next(200)),
                      Anuncio = MockService.GenerateRandomString(rnd.Next(150)),
                      Trailer = "https://www.youtube.com/watch?v=hK8XQALVI3Q",
                      Fecha = DateTime.Now,
                      Puntuacion = Convert.ToDecimal(rnd.NextDouble()) * +rnd.Next(9),
                      Imagen = "https://picsum.photos/200/300",
                      Portada = "https://picsum.photos/700",
                      SubcategoriaID = rnd.Next(59) + 1
                  }
                );
            }

            for (var i = 0; i < 5000; i++)
            {
                builder.Entity<Comentario>().HasData(
                    new Comentario
                    {
                        Id = i + 1,
                        Descripcion = MockService.GenerateRandomString(rnd.Next(150)),
                        Nota = Convert.ToDecimal(rnd.NextDouble()) * +rnd.Next(9),
                        Fecha = DateTime.Now,
                        UserId = rnd.Next(299) + 1,
                        CriticaId = rnd.Next(1499) + 1
                    }
                );
            }

        }
    }
}
