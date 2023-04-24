using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestRamsay.Core.DTOs;
using TestRamsay.Data.Entities;
using TestRamsay.Data.Interfaces;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly TestRamsayDBContext context;
        private readonly MapperConfiguration configuration;
        private readonly Mapper mapper;

        public StudentRepository(TestRamsayDBContext context)
        {
            this.context = context;
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentDTO, Student>();
                cfg.CreateMap<Student, StudentDTO>();
                cfg.CreateMap<GenderDTO, Gender>();
                cfg.CreateMap<Gender, GenderDTO>();
                cfg.CreateMap<DegreeDTO, Degree>();
                cfg.CreateMap<Degree, DegreeDTO>();
            });
            mapper = new Mapper(configuration);
        }

        public StudentDTO Create(StudentDTO student)
        {
            var db = mapper.Map<Student>(student);
            context.Entry(db.Gender).State = EntityState.Unchanged;
            context.Entry(db.Degree).State = EntityState.Unchanged;
            context.Student.Add(db);
            context.SaveChanges();
            return mapper.Map<StudentDTO>(db);
        }

        public bool Delete(int id)
        {
            var db = context.Student.Where(g => g.Id == id).FirstOrDefault();
            if (db is null) return false;

            context.Remove(db);
            context.SaveChanges();
            return true;
        }

        public List<StudentDTO> GetAll()
        {
            var db = context.Student
                .Include(g => g.Gender)
                .Include(d => d.Degree)
                .ToList();
            return mapper.Map<List<StudentDTO>>(db);
        }

        public StudentDTO GetById(int id)
        {
            var db = context.Student
                .Include(g => g.Gender)
                .Include(d => d.Degree)
                .Where(g => g.Id == id).FirstOrDefault();
            return mapper.Map<StudentDTO>(db);
        }

        public StudentDTO Update(StudentDTO student)
        {
            var db = mapper.Map<Student>(student);
            context.Entry(db.Gender).State = EntityState.Unchanged;
            context.Entry(db.Degree).State = EntityState.Unchanged;
            context.Update(db);
            context.SaveChanges();
            return student;
        }
    }
}

