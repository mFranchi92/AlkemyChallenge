using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alkemy2.Models
{
    public class AppUser
    {
        public string Email { get; internal set; }
        public string SecurityStamp { get; internal set; }
    }
}
