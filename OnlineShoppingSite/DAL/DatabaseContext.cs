using DAL.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DatabaseContext :  DbContext
    {
       public DatabaseContext() :base("DefaultConnection")
       {

       }

       public DbSet<Cart> Carts { get; set; }
       public DbSet<CartItem> CartItems { get; set; }
       public DbSet<Category> Categories { get; set; }
       public DbSet<OrderDetails> OrderDetails { get; set; }
       public DbSet<OrderDetailsItems> OrderDetailsItems { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<Role> Roles { get; set; }
       public DbSet<TransactionDetails> TransactionDetails { get; set; }
       public DbSet<User> Users { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Configurations.Add<Cart>(new CartMap());
           modelBuilder.Configurations.Add<CartItem>(new CartItemMap());
           modelBuilder.Configurations.Add<Category>(new CategoryMap());
           modelBuilder.Configurations.Add<OrderDetails>(new OrderDetailsMap());
           modelBuilder.Configurations.Add<OrderDetailsItems>(new OrderDetailsItemsMap());
           modelBuilder.Configurations.Add<Product>(new ProductMap());
           modelBuilder.Configurations.Add<Role>(new RoleMap());
           modelBuilder.Configurations.Add<TransactionDetails>(new TransactionDetailsMap());
           modelBuilder.Configurations.Add<User>(new UserMap());
       }
    }
}
