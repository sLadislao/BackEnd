using System;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestRamsay.Core.DTOs;
using TestRamsay.Data.Interfaces;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Implementations
{
    public class GenderRepository : IGenderRepository
    {
        private readonly TestRamsayDBContext context;
        private readonly MapperConfiguration configuration;
        private readonly Mapper mapper;

        public GenderRepository(TestRamsayDBContext context)
        {
            this.context = context;
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GenderDTO, Gender>();
                cfg.CreateMap<Gender, GenderDTO>();
            });
            mapper = new Mapper(configuration);
        }

        public GenderDTO Create(GenderDTO gender)
        {
            var db = mapper.Map<Gender>(gender);
            context.Gender.Add(db);
            context.SaveChanges();
            return mapper.Map<GenderDTO>(db);
        }

        public bool Delete(int id)
        {
            var db = context.Gender.Where(g => g.Id == id).FirstOrDefault();
            if (db is null) return false;

            context.Remove(db);
            context.SaveChanges();
            return true;
        }

        public List<GenderDTO> GetAll()
        {
            var db = context.Gender.ToList();
            return mapper.Map<List<GenderDTO>>(db);
        }

        public GenderDTO GetById(int id)
        {
            var db = context.Gender.Where(g => g.Id == id).FirstOrDefault();
            return mapper.Map<GenderDTO>(db);
        }

        public GenderDTO Update(GenderDTO gender)
        {
            var db = mapper.Map<Gender>(gender);
            context.Update(db);
            context.SaveChanges();
            return gender;
        }
    }
}