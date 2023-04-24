using System;
using TestRamsay.Bussiness.Interfaces;
using TestRamsay.Core.DTOs;
using TestRamsay.Data.Interfaces;

namespace TestRamsay.Bussiness.Implementations
{
    public class GenderService : IGenderService
    {
        private readonly IGenderRepository genderRepository;
        public GenderService(IGenderRepository genderRepository)
        {
            this.genderRepository = genderRepository;
        }

        public List<GenderDTO> GetAll()
        {
            return genderRepository.GetAll();
        }

        public GenderDTO GetById(int id)
        {
            return genderRepository.GetById(id);
        }

        public GenderDTO Save(GenderDTO gender)
        {
            if (gender.Id > 0) return genderRepository.Update(gender);
            else return genderRepository.Create(gender);
        }

        public bool Delete(int id)
        {
            return genderRepository.Delete(id);
        }
    }
}