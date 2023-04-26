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

        public static ModeratorDTO Get(int id)
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
        
    }
}
