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
    internal sealed class MotorcycleService : IMotorcycleService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public MotorcycleService(IRepositoryWrapper repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _loggerManager = logger;
            _mapper = mapper;
        }

        public void createMoto(Motorcycle moto) => _repository.Motorcycle.CreateMotorcycle(moto);

        public void CreateMoto(Motorcycle moto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MotorcycleDto> GetAllMotorcyclesDTO(bool trackChanges)
        {
            var motorcycles = _repository.Motorcycle.GetAll(trackChanges);
            var motorcyclesDTO = _mapper.Map<IEnumerable<MotorcycleDto>>(motorcycles);

            return motorcyclesDTO;
            
        }
    }
}
