using System;
using TestRamsay.Core.DTOs;

namespace TestRamsay.Data.Interfaces
{
	public interface IStudentRepository
	{
        StudentDTO Create(StudentDTO gender);
        StudentDTO Update(StudentDTO gender);
        StudentDTO GetById(int id);
        List<StudentDTO> GetAll();
        bool Delete(int id);
    }
}

