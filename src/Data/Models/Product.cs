using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace tcms.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(2000)]
        public string Description { get; set; }
    }
}
