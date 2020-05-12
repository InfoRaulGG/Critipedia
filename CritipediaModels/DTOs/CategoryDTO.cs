using System;
using System.Collections.Generic;
using System.Text;

namespace CritipediaModels.DTOs
{
    public class CategoryDTO
    {
        public string Name { get; set; }
        public List<SubcategoryDTO> Subcategorys { get; set; }
    }
}
