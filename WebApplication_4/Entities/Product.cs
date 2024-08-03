using System.ComponentModel.DataAnnotations;

namespace WebApplication_4.Entities
{
    public class Product
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Name CANNOT be NULL!")]
        public string Name { get; set; }
        [Range(1,1000,ErrorMessage ="Price must me higher than 0, lowr than 1000")]
        public decimal Price { get; set; }

    }
}
