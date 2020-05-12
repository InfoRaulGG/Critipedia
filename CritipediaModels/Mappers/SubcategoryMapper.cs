using CritipediaModels.DTOs;
using Entities;

namespace CritipediaModels.Mappers
{
    public static class SubcategoryMapper
    {
        public static SubcategoryDTO Map(Subcategoria subCat)
        {
            SubcategoryDTO returnDto = new SubcategoryDTO();
            returnDto.Name = subCat.Nombre;
            returnDto.CategoryId = subCat.CategoriaId;

            return returnDto;
        }
    }
}
