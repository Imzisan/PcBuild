﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SalesReport
    {
        public int Id { get; set; }

        public string MonthName { get; set; }

        public int TotalSales { get; set; }
        [ForeignKey("Moderator")]

        public string ReportedBy { get; set; }

        //[ForeignKey("Order")]
        //public int OrderId { get; set; }


        public virtual Moderator Moderator { get; set; }

        //public  virtual Order Order { get; set; }



        //public virtual ICollection<Order> Orders { get; set; }



        //public SalesReport() { 

        //    Orders= new List<Order>();
        //}

    }
}
