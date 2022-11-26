using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAgencyService> _agencyService;

        private readonly Lazy<ICityService> _cityService;

        private readonly Lazy<IClientService> _clientService;


        public ServiceManager(IRepositoryWrapper repositoryManager, ILoggerManager loggerManager)
        {
            _agencyService = new Lazy<IAgencyService>(()=> new AgencyService(repositoryManager, loggerManager));
            _clientService = new Lazy<IClientService>(() => new ClientService(repositoryManager, loggerManager));
             _cityService = new Lazy<ICityService>(() => new CityService(repositoryManager, loggerManager));
        }

        public IAgencyService AgencyService => _agencyService.Value;

        public ICityService CityService => _cityService.Value;

        public IClientService ClientService => _clientService.Value;
    }
}
