using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class OrderAccording
    {
        public int OAId { get; set; }
        public string OrderPicture { get; set; }
        public string CommodityColor { get; set; }
        public int Sizes_Id { get; set; }
        public int CommodityNumber { get; set; }
        public DateTime OrderTime { get; set; }
        public string OrderNumber { get; set; }
        public int PaymentStatus { get; set; }
        public decimal TotalPrices { get; set; }
        public string Norm { get; set; }
    }
}
