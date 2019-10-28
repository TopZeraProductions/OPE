using System.Collections.Generic;
using DTO.Clients;
using DTO.SharedKernel;

namespace DTO.Orders
{
    public class Order : DefaultEntity
    {
        public int? IdClient { get; set; }

        public virtual Client Client { get; set; }

        public decimal? TotalValue { get; set; }

        public decimal? Discount { get; set; }

        public virtual IList<OrderItem> OrderItems { get; set; }

        public byte? Status { get; set; }
        
        public byte? PaymentMode { get; set; }
    }
}