using WebApplication4.Models.Common;

namespace WebApplication4.Models
{
    public class Slider : BaseEntity
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ImageUrl { get; set; }
        public int Discount { get; set; }
    }
}
