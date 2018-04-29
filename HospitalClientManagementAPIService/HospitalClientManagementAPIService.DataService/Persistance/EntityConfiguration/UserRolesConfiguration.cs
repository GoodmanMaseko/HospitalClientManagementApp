using HospitalClientManagementAPIService.DataService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClientManagementAPIService.DataService.Persistance.EntityConfiguration
{
    public class UserRolesConfiguration: EntityTypeConfiguration<UserRoles>
    {
        public UserRolesConfiguration()
        {
            
        }
    }
}
