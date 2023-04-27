using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AdminDTO>>(data);
            return mapped;

        }

        public static AdminDTO Get(string id)
        {
            var data = DataAccessFactory.AdminData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminDTO>(data);
            return mapped;
        }
        public static Admin Create(AdminDTO Admin)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Admin>(Admin);
            var res = DataAccessFactory.AdminData().Create(mapped);
            return mapped;
        }

        public static Admin Update(AdminDTO Admin)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Admin>(Admin);
            var res = DataAccessFactory.AdminData().Create(mapped);
            return mapped;
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.AdminData().Delete(id);
        }

    }
}
