using HospitalClientManagementAPIService.DataService.Interfaces.Reposotory;
using HospitalClientManagementAPIService.DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClientManagementAPIService.DataService.Persistance.Repository
{
    public class RolesRepository:Repository<Role>,IRolesRepository
    {
        public RolesRepository(HospitalClientManagement_db hospitalClientManagement_db)
            :base(hospitalClientManagement_db)
        {

        }


        
        public HospitalClientManagement_db hospitalClientManagement_db
        {
            get
            {
                return _hospitalClientManagement_db as HospitalClientManagement_db;
            }
        }
    }
}
