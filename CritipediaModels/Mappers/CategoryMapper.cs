using CritipediaModels.DTOs;
using System.Linq;
using Entities;

namespace CritipediaModels.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryDTO Map(Categoria cat)
        {
            CategoryDTO returnDto = new CategoryDTO();
            returnDto.Name = cat.Nombre;

            foreach (var s in cat.Subcategorias)
            {
                var subCategoryDto = new SubcategoryDTO();
                subCategoryDto = SubcategoryMapper.Map(s);

                returnDto.Subcategorys.Add(subCategoryDto);
            }

            return returnDto;
        }
    }
}
