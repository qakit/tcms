using System;

namespace tcms.Data.Models
{
    public partial class PostProductVersionDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? StartDate;
        public DateTime? EndDate;

        public ProductVersion Adapt()
        {
            return new ProductVersion { Name = Name, Description = Description, IsActive = IsActive ?? false, StartDate = StartDate ?? DateTime.Now, EndDate = EndDate ?? DateTime.Now };
        }
        public void MergeTo(ProductVersion product)
        {
            if (Name != null) product.Name = Name;
            if (Description != null) product.Description = Description;
            if (IsActive != null) product.IsActive = IsActive.Value;
            if (StartDate != null) product.StartDate = StartDate.Value;
            if (EndDate != null) product.EndDate = EndDate.Value;

            Console.WriteLine(StartDate);
            Console.WriteLine(product.StartDate);
        }
    }

}