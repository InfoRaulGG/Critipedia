using CritipediaModels.DTOs;
using Entities;

namespace CritipediaModels.Mappers
{
    public static class CommentMapper
    {
        public static CommentDTO Map(Comentario cmt)
        {
            CommentDTO returnDto = new CommentDTO();
            returnDto.Description = cmt.Descripcion;
            returnDto.Date = cmt.Fecha;
            returnDto.Punctuation = cmt.Nota;
            returnDto.ReviewId = cmt.CriticaId;
            //returnDto.User = UserMapper.Map(cmt.Usuario);

            return returnDto;
        }
    }
}
