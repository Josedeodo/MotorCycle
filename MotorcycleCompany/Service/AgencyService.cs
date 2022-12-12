using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    internal sealed class AgencyService : IAgencyService
    {

        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public AgencyService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<AgencyDto> GetAllAgenciesDTO(bool trackChanges)
        {
            var agencies = _repository.Agency.GetAll(trackChanges);
            var agenciesDto = _mapper.Map<IEnumerable<AgencyDto>>(agencies);

            return agenciesDto;
        }
    }
}
