using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ModeratorService
    {
        public static List<ModeratorDTO> Get()
        {
            var data = DataAccessFactory.ModeratorData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Moderator, ModeratorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ModeratorDTO>>(data);
            return mapped;

        }

        public static ModeratorDTO Get(string id)
        {
            var data = DataAccessFactory.ModeratorData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Moderator, ModeratorDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ModeratorDTO>(data);
            return mapped;
        }
        public static ModeratorSalesReportDTO GetwithSalesReport(string id)
        {
            var data = DataAccessFactory.ModeratorData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Moderator, ModeratorSalesReportDTO>();
                c.CreateMap<SalesReport, SalesReportDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ModeratorSalesReportDTO>(data);
            return mapped;

        }
        public static Moderator Create(ModeratorDTO Moderator)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ModeratorDTO, Moderator>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Moderator>(Moderator);
            var res = DataAccessFactory.ModeratorData().Create(mapped);
            return mapped;
        }

        public static Moderator Update(ModeratorDTO Moderator)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ModeratorDTO, Moderator>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Moderator>(Moderator);
            var res = DataAccessFactory.ModeratorData().Create(mapped);
            return mapped;
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.ModeratorData().Delete(id);
        }

    }

}

