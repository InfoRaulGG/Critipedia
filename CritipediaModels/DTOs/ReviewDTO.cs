using System;
using System.Collections.Generic;
using System.Text;

namespace CritipediaModels.DTOs
{
    public class ReviewDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Announce { get; set; }
        public string Trailer { get; set; }
        public DateTime Date { get; set; }
        public decimal Punctuation { get; set; }
        public string Image { get; set; }
        public string Cover { get; set; }

        public SubcategoryDTO Subcategory{ get; set; }
        public List<CommentDTO> Comments { get; set; }
    }
}
