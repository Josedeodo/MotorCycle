using AutoMapper;
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
    internal sealed class ClientService : IClientService
    {

        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public ClientService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            _mapper = mapper;
        }

        public void CreateClient(Client client)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAllClients(bool trackChanges)
        {
            try
            {

                return _repository.Client.GetAll(trackChanges);
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Mas dañino que el azucar: {ex.Message}");
                throw;
            }
        }
    }
}
