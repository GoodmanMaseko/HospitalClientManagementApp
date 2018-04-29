using HospitalClientManagementAPIService.DataService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClientManagementAPIService.DataService.Persistance.EntityConfiguration
{
    public class UserEntityConfiguration: EntityTypeConfiguration<User>
    {
        public UserEntityConfiguration()
        {
            Property(x => x.Name).HasMaxLength(50);
            Property(x => x.Surname).HasMaxLength(50);
            Property(x => x.IdNumber).HasMaxLength(50);
            Property(x => x.Password).HasMaxLength(50);
            Property(x => x.TellphoneNumber).HasMaxLength(15);
            Property(x => x.Email).HasMaxLength(50);
            Property(x => x.CellNumber).HasMaxLength(15);

            HasMany(x => x.Roles).WithMany(u => u.Users)
                .Map(t => t.ToTable("UserRole")
                .MapLeftKey("UserId").MapRightKey("RoleId"));

        }
    }
}
