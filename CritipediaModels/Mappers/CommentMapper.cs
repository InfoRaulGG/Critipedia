using CritipediaModels.DTOs;
using Entities;
using System.Collections.Generic;

namespace CritipediaModels.Mappers
{
    public static class CommentMapper
    {
        public static object Map(object cmts)
        {
            if (cmts is List<Comentario>)
            {
                List<CommentDTO> returnDto = new List<CommentDTO>();

                foreach (var cmt in (List<Comentario>)cmts)
                {
                    CommentDTO ObjectMap = new CommentDTO();

                    ObjectMap.Description = cmt.Descripcion;
                    ObjectMap.Date = cmt.Fecha;
                    ObjectMap.Punctuation = cmt.Nota;
                    ObjectMap.ReviewId = cmt.CriticaId;
                    ObjectMap.UserId = cmt.UserId;

                    returnDto.Add(ObjectMap);
                }

                return returnDto;
            }
            else
            {
                CommentDTO returnDto = new CommentDTO();
                var cmt = (Comentario)cmts;

                returnDto.Description = cmt.Descripcion;
                returnDto.Date = cmt.Fecha;
                returnDto.Punctuation = cmt.Nota;
                returnDto.ReviewId = cmt.CriticaId;
                returnDto.UserId = cmt.UserId;

                return returnDto;
            }
        }
    }
}
