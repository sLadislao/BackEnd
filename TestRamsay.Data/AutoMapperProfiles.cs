using System;
using AutoMapper;
using TestRamsay.Core.DTOs;
using TestRamsay.Data.Models;

namespace TestRamsay.Data
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles()
		{
            CreateMap<GenderDTO, Gender>();
        }

	}
}

