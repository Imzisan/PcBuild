﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public  class Seller
    {
        [Key]
        public  string  Sname { get; set; }
        [Required]
        [StringLength(15)]
        public string Password { get; set; }
        [Required]
        [StringLength(15)]
        public string Name { get; set; }
        [Required]
        [StringLength(15)]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string NidNumber  { get; set; }

        public int AdminId { get; set; }


        public virtual Admin Admin { get; set; }


    }
}
