using DTO.Orders;

namespace WEB.Areas.Orders.Models.Forms {

    public class RegisterOrderForm {

        public int idClient { get; set; }

        public Order Order { get; set; }

        public int[] IdsProducts { get; set; }

        public byte? PaymentMode { get; set; }

    }

}