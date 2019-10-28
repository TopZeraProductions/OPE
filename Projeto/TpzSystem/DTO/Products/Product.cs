using DTO.SharedKernel;

namespace DTO.Products {
    public class Product : DefaultEntity {

        public string ProductName { get; set; }

        public decimal? UnitaryPrice { get; set; }

        public string Description { get; set; }
        
        public int? Quantity { get; set; }
        
        public string ImageUrl { get; set; }
    }
}