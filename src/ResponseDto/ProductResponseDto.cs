namespace tcms.Data.Models
{
    public partial class ProductResponseDto: BaseEntityDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static ProductResponseDto FromProduct(Product p)
        {
            return new ProductResponseDto {
                ProductId = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                CreatedBy = p.CreatedBy,
                CreatedDate = p.CreatedDate,
                ModifiedBy = p.ModifiedBy,
                ModifiedDate = p.ModifiedDate,
            };
        }
    }
}