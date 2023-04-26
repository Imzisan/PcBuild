﻿using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DataAccessFactory
    {

        public static IRepo<Seller , string, Seller> SellerData()
        {
            return new SellerRepo();
        }
        public static IRepo<Product , int , bool> ProductData()
        {
            return new ProductRepo();
        }

        public static IRepo<Order, int, bool> OrderData()
        {
            return new OrderRepo();
        }
        public static IRepo<Admin, int, Admin> AdminData()
        {
            return new AdminRepo();
        }
        public static IRepo<Moderator, int, Moderator> ModeratorData()
        {
            return new ModeratorRepo();
        }
    }
}
