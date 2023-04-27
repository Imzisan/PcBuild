using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Admin
    {
        [Key]

        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(11)]

        public string Phone { get; set; }

        public virtual ICollection<Moderator> Moderators { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }

        public virtual ICollection<SalesReport> SalesReports { get; set; }

        public Admin()
        {
            Moderators = new List<Moderator>();
            Sellers = new List<Seller>();
            SalesReports = new List<SalesReport>();
            
        }
    }
}

