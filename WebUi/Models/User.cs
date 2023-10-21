using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebUi.Models
{
    public class User : IdentityUser
    {
        public string FirtstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }
        public string About { get; set; }


    }
}