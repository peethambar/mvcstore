using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappings
{
    public class OrderDetailsItemsMap : EntityTypeConfiguration<OrderDetailsItems>
    {
        public OrderDetailsItemsMap()
        {
            this.HasKey(o => o.OrderDetailsItemsId);
            //foreign-key
            this.HasRequired(o => o.OrderDetails).WithMany(o => o.Items).HasForeignKey(o => o.OrderDetailsId);
        }
    }
}
