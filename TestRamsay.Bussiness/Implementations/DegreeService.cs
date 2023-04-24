using System;
using TestRamsay.Bussiness.Interfaces;
using TestRamsay.Core.DTOs;
using TestRamsay.Data.Implementations;
using TestRamsay.Data.Interfaces;

namespace TestRamsay.Bussiness.Implementations
{
    public class DegreeService : IDegreeService
    {
        private readonly IDegreeRepository degreeRepository;
        public DegreeService(IDegreeRepository degreeRepository)
        {
            this.degreeRepository = degreeRepository;
        }

        public List<DegreeDTO> GetAll()
        {
            return degreeRepository.GetAll();
        }

        public DegreeDTO GetById(int id)
        {
            return degreeRepository.GetById(id);
        }

        public DegreeDTO Save(DegreeDTO gender)
        {
            if (gender.Id > 0) return degreeRepository.Update(gender);
            else return degreeRepository.Create(gender);
        }

        public bool Delete(int id)
        {
            return degreeRepository.Delete(id);
        }
    }
}