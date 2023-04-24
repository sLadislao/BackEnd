using System;
using TestRamsay.Core.DTOs;

namespace TestRamsay.Bussiness.Interfaces
{
	public interface IGenderService
	{
        GenderDTO Save(GenderDTO gender);
        GenderDTO GetById(int id);
        List<GenderDTO> GetAll();
        bool Delete(int id);
    }
}