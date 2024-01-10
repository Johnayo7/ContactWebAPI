using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactWebAPI.SqlServer
{
    public class ApplicationIdentityRole : IdentityRole
    {
        public ApplicationIdentityRole(string role): base(role)
        {

        }
    }
}
