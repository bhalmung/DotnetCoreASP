using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDotnetCoreWebApplication.Models
{
    [Table("UserDetails")]
    public class UserDetails
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
