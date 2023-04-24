using System;
using TestRamsay.Bussiness.Interfaces;
using TestRamsay.Core.DTOs;
using TestRamsay.Data.Implementations;
using TestRamsay.Data.Interfaces;
using TestRamsay.Data.Models;

namespace TestRamsay.Bussiness.Implementations
{
    public class StudentServive : IStudentServive
    {
        private readonly IStudentRepository studentRepository;

        public StudentServive(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public List<StudentDTO> GetAll()
        {
            return studentRepository.GetAll();
        }

        public StudentDTO GetById(int id)
        {
            return studentRepository.GetById(id);
        }
        public StudentDTO Save(StudentDTO student)
        {
            if (student.Id > 0) return studentRepository.Update(student);
            else return studentRepository.Create(student);
        }

        public bool Delete(int id)
        {
            return studentRepository.Delete(id);
        }
    }
}