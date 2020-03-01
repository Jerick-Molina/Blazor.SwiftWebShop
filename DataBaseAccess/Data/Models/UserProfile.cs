using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseAccess.Data.Models
{
    public class UserProfile
    {
        [Key]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string UserCash { get; set; }
    }
}
