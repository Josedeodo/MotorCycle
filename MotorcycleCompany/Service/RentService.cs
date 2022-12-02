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
    public sealed class RentService : IRentService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public RentService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            _repository = repository;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public void createRent(Rent rent) => _repository.Rent.CreateRent(rent);

        public IEnumerable<RentDto> GetAllRentsDTO(bool trackChanges)
        {
           var rents = _repository.Rent.GetAll(trackChanges);
           var rentsDto = _mapper.Map<IEnumerable<RentDto>>(rents);


           return rentsDto;

        }


       
    }
}
