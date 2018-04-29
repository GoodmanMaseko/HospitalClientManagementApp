using HospitalClientManagementAPIService.DataService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClientManagementAPIService.DataService.Persistance.EntityConfiguration
{
    public class RolesEntityConfiguration: EntityTypeConfiguration<Role>
    {
        public RolesEntityConfiguration()
        {
            Property(x => x.Name).HasMaxLength(50);
        }
    }
}
