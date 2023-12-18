using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lesson43_Task.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title can not be empty")]
        [StringLength(50)]
        [NotNull]
        public required string Title { get; set; }
        [Required(ErrorMessage = "Text can not be empty")]
        [StringLength(250)]
        [NotNull]
        public required string Text { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Date can not be empty")]
        public DateTime Time { get; set; }

    }
}

