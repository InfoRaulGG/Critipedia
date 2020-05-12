using System;
using System.ComponentModel.DataAnnotations;

namespace CritipediaModels.DTOs
{
    public class CommentDTO
    {
        public string Description { get; set; }
        public decimal Punctuation { get; set; }
        public DateTime Date { get; set; }
        public int ReviewId { get; set; }
        public int UserId { get; set; }
    }
}
