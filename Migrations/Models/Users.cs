using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Migrations.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }
    }
}