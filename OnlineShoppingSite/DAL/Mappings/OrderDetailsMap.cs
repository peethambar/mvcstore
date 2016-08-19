using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappings
{
    public class OrderDetailsMap : EntityTypeConfiguration<OrderDetails>
    {
        public OrderDetailsMap()
        {
            this.HasKey(o => o.OrderDetailsId);

            //forign-key
            this.HasRequired(o => o.User).WithMany().HasForeignKey(o => o.UserId).WillCascadeOnDelete(false);
            this.HasRequired(o => o.Cart).WithMany().HasForeignKey(o => o.CartId);
        }
    }
}
