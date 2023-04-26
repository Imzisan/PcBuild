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
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Moderator> Moderators { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }

        public Admin()
        {
            Moderators = new List<Moderator>();
            Sellers = new List<Seller>();
        }
    }
}

