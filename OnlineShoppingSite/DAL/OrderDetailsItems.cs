using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDetailsItems
    {
        public int OrderDetailsItemsId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }

        public int OrderDetailsId { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }
    }
}
