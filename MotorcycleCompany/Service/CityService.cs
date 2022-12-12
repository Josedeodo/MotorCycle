using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class CityService : ICityService
    {

        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public CityService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public void CreateCity(City city)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CityDto> GetAllCitiesDTO(bool trackChanges)
        {
            var cities = _repository.City.GetAll(trackChanges);
            var citiesDto = _mapper.Map<IEnumerable<CityDto>>(cities);

            return citiesDto;

        }
    }
}
