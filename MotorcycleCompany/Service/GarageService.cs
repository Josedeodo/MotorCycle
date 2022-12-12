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
    internal sealed class GarageService : IGarageService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public GarageService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            _repository = repository;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }
        public IEnumerable<GarageDto> GetAllGarages(bool trackChanges)
        {
            var garages = _repository.Garage.GetAll(trackChanges);
            var garagesDto = _mapper.Map<IEnumerable<GarageDto>>(garages);

            return garagesDto;
        }
    }
}
