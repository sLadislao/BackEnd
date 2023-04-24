using System;
using TestRamsay.Core.DTOs;

namespace TestRamsay.Data.Interfaces
{
	public interface IDegreeRepository
	{
        DegreeDTO Create(DegreeDTO gender);
        DegreeDTO Update(DegreeDTO gender);
        DegreeDTO GetById(int id);
        List<DegreeDTO> GetAll();
        bool Delete(int id);
    }
}