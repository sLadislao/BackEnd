using System;
using TestRamsay.Core.DTOs;

namespace TestRamsay.Bussiness.Interfaces
{
	public interface IDegreeService
	{
        DegreeDTO Save(DegreeDTO gender);
        DegreeDTO GetById(int id);
        List<DegreeDTO> GetAll();
        bool Delete(int id);
    }
}

