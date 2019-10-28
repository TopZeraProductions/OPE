using DTO.Products;
using DTO.SharedKernel;

namespace DTO.Orders {

    public class OrderItem : DefaultEntity {

        public int? IdOrder { get; set; }

        public virtual Order Order { get; set; }

        public int? IdProduct { get; set; }

        public virtual Product Product { get; set; }

    }

}