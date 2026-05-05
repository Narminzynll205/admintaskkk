using System.ComponentModel.DataAnnotations;
using WebApplication4.Models.Common;

namespace WebApplication4.Models
{
    public class Slider : BaseEntity
    {
        [Required(ErrorMessage = "Title is required")]
        [
           StringLength(15, ErrorMessage = "Title must be maximum 15 characters.."),
           MinLength(3, ErrorMessage = "Title must be at least 3 characters")
       ]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required ")]
        [
           StringLength(200, ErrorMessage = "Title must be maximum 200 characters.."),
           MinLength(1, ErrorMessage = "Title must be at least 1 characters")
       ]
        public string Desc { get; set; }

        [Required(ErrorMessage = "Image is required...")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Discount is required...")]
        [Range(0, 100, ErrorMessage = "Discount must be between 0-100")]
        public int Discount { get; set; }
    }
}
