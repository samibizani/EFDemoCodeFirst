using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultiDataContextMigrations.Models
{
    public class User
    {
        public int UserID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        [NotMapped]
        public int Age { set; get; }
    }
}