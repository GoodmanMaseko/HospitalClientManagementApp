using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClientManagementAPIService.DataService.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string IdNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CellNumber { get; set; }
        public string TellphoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}
