using CritipediaModels.DTOs;
using System.Linq;
using Entities;
using System.Collections.Generic;

namespace CritipediaModels.Mappers
{
    public static class CategoryMapper
    {
        public static object Map(object cat)
        {
            if (cat is List<Categoria>)
            {
                List<CategoryDTO> returnDto = new List<CategoryDTO>();

                foreach (var cmt in (List<Comentario>)cat)
                {
                    CategoryDTO ObjectMap = new CategoryDTO();

                    ObjectMap.Name = cmt.Descripcion;

                    returnDto.Add(ObjectMap);
                }

                return returnDto;
            }
            else
            {
                CategoryDTO returnDto = new CategoryDTO();

                var catMap = (CategoryDTO)cat;

                returnDto.Name = catMap.Name;

                return returnDto;
            }
        }
    }
}
