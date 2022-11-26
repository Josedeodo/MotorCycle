﻿using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class PhoneService : IPhoneService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _logger;

        public PhoneService(IRepositoryWrapper repository, ILoggerManager logger)
        {
            _repository= repository;
            _logger= logger;

        }


    }
}
