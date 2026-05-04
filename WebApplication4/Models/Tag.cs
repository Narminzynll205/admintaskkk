using WebApplication4.Models.Common;

namespace WebApplication4.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
