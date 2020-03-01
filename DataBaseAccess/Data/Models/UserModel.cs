
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseAccess.Data.Models
{
    public class UserModel : IdentityUser
    { [ForeignKey("UserId")]
        public int UserId { get; set; }

        public UserProfile User { get; set; }
    }
}
