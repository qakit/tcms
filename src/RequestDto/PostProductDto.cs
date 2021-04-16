namespace tcms.Data.Models
{
    public partial class PostProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Product ToProduct()
        {
            return new Product { Name = Name, Description = Description };
        }
        public Product ToProduct(Product product)
        {
            if (Name != null) product.Name = Name;
            if (Description != null) product.Description = Description;
            return product;
        }
    }

}