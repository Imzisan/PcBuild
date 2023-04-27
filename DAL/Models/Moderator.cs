using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Moderator
    {
        [Key]
        public string UserName { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public decimal Salary { get; set; }

        [ForeignKey("Admin")]

        public string AddedBy { get; set; }


        public virtual Admin Admin { get; set; }

        public virtual ICollection<SalesReport> SalesReports { get; set; }

        public Moderator() { 
        SalesReports = new List<SalesReport>();
        }
    }
}
