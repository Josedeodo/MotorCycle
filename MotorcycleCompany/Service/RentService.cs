using Contracts;
using Service.Contracts;
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

        public RentService(IRepositoryWrapper repository, ILoggerManager loggerManager)
        {
            _repository = repository;
            _loggerManager = loggerManager;
        }
    }
}
