using HospitalClientManagementAPIService.DataService.Interfaces;
using HospitalClientManagementAPIService.DataService.Interfaces.Reposotory;
using HospitalClientManagementAPIService.DataService.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClientManagementAPIService.DataService.Persistance
{
    public class UnitOfwork:IUnitOfWork
    {
        protected readonly HospitalClientManagement_db _hospitalClientManagement_db;

        public UnitOfwork(HospitalClientManagement_db hospitalClientManagement_db)
        {
            _hospitalClientManagement_db = hospitalClientManagement_db;
            UserRoles = new UserRolesRepository(_hospitalClientManagement_db);
            Users = new UserRepository(_hospitalClientManagement_db);
            Roles = new RolesRepository(_hospitalClientManagement_db);
        }

        public IUserRepository Users { get; private set; }
        public IUserRolesRepository UserRoles { get; private set; }
        public IRolesRepository Roles { get; private set; }
    }
}
