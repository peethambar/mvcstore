using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappings
{
    public class TransactionDetailsMap : EntityTypeConfiguration<TransactionDetails>
    {
        public TransactionDetailsMap()
        {
            this.HasKey(t => t.TransactionDetailsId);

            //foreign-key
            this.HasRequired(t => t.Cart).WithMany().HasForeignKey(t => t.CartId);
            this.HasRequired(t => t.User).WithMany().HasForeignKey(t => t.UserId);
        }
    }
}
