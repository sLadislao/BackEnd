using System;
using AutoMapper;
using TestRamsay.Core.DTOs;
using TestRamsay.Data.Entities;
using TestRamsay.Data.Interfaces;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Implementations
{
    public class DegreeRepository : IDegreeRepository
    {
        private readonly TestRamsayDBContext context;
        private readonly MapperConfiguration configuration;
        private readonly Mapper mapper;

        public DegreeRepository(TestRamsayDBContext context)
        {
            this.context = context;
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DegreeDTO, Degree>();
                cfg.CreateMap<Degree, DegreeDTO>();
            });
            mapper = new Mapper(configuration);
        }

        public DegreeDTO Create(DegreeDTO degree)
        {
            var db = mapper.Map<Degree>(degree);
            context.Degree.Add(db);
            context.SaveChanges();
            return mapper.Map<DegreeDTO>(db);
        }

        public bool Delete(int id)
        {
            var db = context.Degree.Where(g => g.Id == id).FirstOrDefault();
            if (db is null) return false;

            context.Remove(db);
            context.SaveChanges();
            return true;
        }

        public List<DegreeDTO> GetAll()
        {
            var db = context.Degree.ToList();
            return mapper.Map<List<DegreeDTO>>(db);
        }

        public DegreeDTO GetById(int id)
        {
            var db = context.Degree.Where(g => g.Id == id).FirstOrDefault();
            return mapper.Map<DegreeDTO>(db);
        }

        public DegreeDTO Update(DegreeDTO degree)
        {
            var db = mapper.Map<Degree>(degree);
            context.Update(db);
            context.SaveChanges();
            return degree;
        }
    }
}

