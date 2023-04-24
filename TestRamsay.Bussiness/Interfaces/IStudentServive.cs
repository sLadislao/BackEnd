using System;
using TestRamsay.Core.DTOs;

namespace TestRamsay.Bussiness.Interfaces
{
	public interface IStudentServive
	{
        StudentDTO Save(StudentDTO gender);
        StudentDTO GetById(int id);
        List<StudentDTO> GetAll();
        bool Delete(int id);
    }
}

