using System;

namespace tcms.Data.Models
{
    public partial class ProductVersionResponseDto: BaseEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public static ProductVersionResponseDto Create(ProductVersion p)
        {
            return new ProductVersionResponseDto {
                Id = p.ProductVersionId,
                Name = p.Name,
                Description = p.Description,
                StartDate = p.StartDate,
                EndDate = p.EndDate,
                IsActive = p.IsActive,

                CreatedBy = p.CreatedBy,
                CreatedDate = p.CreatedDate,
                ModifiedBy = p.ModifiedBy,
                ModifiedDate = p.ModifiedDate,
            };
        }
    }
}