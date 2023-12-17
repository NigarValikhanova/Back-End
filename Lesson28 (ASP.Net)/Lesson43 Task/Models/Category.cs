using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lesson43_Task.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name can not be empty")]
        [StringLength(50)]
        public string CategoryName { get; set; }
        [NotMapped]
        public int Test { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
