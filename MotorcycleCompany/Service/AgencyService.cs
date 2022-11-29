using Contracts;
using Entities.Models;
using Service.Contracts;
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

        public AgencyService(IRepositoryWrapper repository, ILoggerManager loggerManager)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
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

        public IEnumerable<Agency> GetAllIncludeRentAndClient(bool trackChanges)
        {
            try
            {

                return _repository.Agency.GetIncludeRentAndClient(trackChanges);
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Mas dañino que el azucar: {ex.Message}");
                throw;
            }
        }
    }
}
