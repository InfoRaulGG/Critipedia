using CritipediaModels.DTOs;
using Entities;
using System.Collections.Generic;

namespace CritipediaModels.Mappers
{
    public static class ReviewMapper
    {
        public static object Map(object crts)
        {
            if (crts is List<Critica>)
            {
                List<ReviewDTO> returnListDto = new List<ReviewDTO>();

                foreach (var crt in (List<Critica>)crts)
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

                    returnListDto.Add(returnDto);

                }

                return returnListDto;
            }
            else
            {
                ReviewDTO returnDto = new ReviewDTO();

                var crt = (Critica)crts;

                returnDto.Title = crt.Titulo;
                returnDto.Description = crt.Descripcion;
                returnDto.Announce = crt.Anuncio;
                returnDto.Trailer = crt.Trailer;
                returnDto.Date = crt.Fecha;
                returnDto.Image = crt.Imagen;
                returnDto.Cover = crt.Portada;
                returnDto.Punctuation = crt.Puntuacion;

                return returnDto;
            }
         
        }
    }
}
