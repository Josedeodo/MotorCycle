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
        //private readonly IMapper _mapper;

        public AgencyService(IRepositoryWrapper repository, ILoggerManager loggerManager)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            //this._mapper = mapper;
        }

        public void CreateAgency(Agency agency)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Agency> GetAllAgencies(bool trackChanges)
        {
            try
            {
               
                return _repository.Agency.GetAll(trackChanges);
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Mas dañino que el azucar: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<AgencyDto> GetAllAgenciesDTO(bool trackChanges)
        {
            try
            {
                var agencies = _repository.Agency.GetAll(trackChanges);

                var agenciesDto = agencies.Select(x => new AgencyDto(x.AgencyId, x.Address, x.Neighborhood, x.Location, x.Name));

                return agenciesDto;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Mas dañino que el azucar: {ex.Message}");
                throw;
            }
        }
    }
}
