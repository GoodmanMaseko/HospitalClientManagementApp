using HospitalClientManagementAPIService.DataService.Interfaces.Reposotory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClientManagementAPIService.DataService.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users{get;}
        IUserRolesRepository UserRoles { get; }
        IRolesRepository Roles { get; }
    }
}
