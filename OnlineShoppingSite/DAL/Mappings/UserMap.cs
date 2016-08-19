using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(u => u.UserId);
            this.Property(u => u.Username).HasMaxLength(50).IsUnicode(false).IsRequired();
            this.Property(u => u.Password).HasMaxLength(50).IsUnicode(false).IsRequired();
            this.Property(u => u.Name).HasMaxLength(50).IsUnicode(false).IsRequired();
            this.Property(u => u.Address).HasMaxLength(200).IsUnicode(false).IsRequired();

            //many-many
            this.HasMany(u => u.Roles).WithMany(r => r.Users).Map(m =>
            {
                m.MapLeftKey("UserId");
                m.MapRightKey("RoleId");
                m.ToTable("UserRoles");
            });
        }
    }
}
