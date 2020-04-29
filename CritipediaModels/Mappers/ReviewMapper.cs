using CritipediaModels.DTOs;
using Entities;
using System.Collections.Generic;

namespace CritipediaModels.Mappers
{
    public static class ReviewMapper
    {
        public static ReviewDTO Map(Critica crt)
        {
            ReviewDTO returnDto = new ReviewDTO();

            returnDto.Title = crt.Titulo;
            returnDto.Description = crt.Descripcion;
            returnDto.Announce = crt.Anuncio;
            returnDto.Trailer = crt.Trailer;
            returnDto.Date = crt.Fecha;
            returnDto.Image = crt.Imagen;
            returnDto.Cover = crt.Portada;
            returnDto.Punctuation = crt.Puntuacion;
            returnDto.Comments = new List<CommentDTO>();

            foreach(var c in crt.Comentarios)
            {
                returnDto.Comments.Add(CommentMapper.Map(c));
            }

            returnDto.Subcategory = SubcategoryMapper.Map(crt.Subcategoria);

            return returnDto;
        }

        public static List<ReviewDTO> MapAll(List<Critica> crts)
        {
            List<ReviewDTO> returnDto = new List<ReviewDTO>();

            foreach(var c in crts)
            {
                returnDto.Add(Map(c));
            }

            return returnDto;
        }
    }
}
