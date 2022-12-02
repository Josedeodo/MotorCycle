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

        public IEnumerable<ClientDto> GetAllClients(bool trackChanges)
        {
            var clients = _repository.Client.GetAll(trackChanges);
            var clientsDto = _mapper.Map<IEnumerable<ClientDto>>(clients);

            return clientsDto;
        }
    }
}
