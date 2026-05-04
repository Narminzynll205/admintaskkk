using Microsoft.AspNetCore.Mvc.ViewEngines;
using WebApplication4.Models.Common;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication4.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Image> Images { get; set; }
       
    }
}
