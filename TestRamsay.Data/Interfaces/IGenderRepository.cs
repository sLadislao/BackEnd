using System;
using TestRamsay.Core.DTOs;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Interfaces
{
	public interface IGenderRepository
	{
		GenderDTO Create(GenderDTO gender);
        GenderDTO Update(GenderDTO gender);
		GenderDTO GetById(int id);
		List<GenderDTO> GetAll();
		bool Delete(int id);
    }
}