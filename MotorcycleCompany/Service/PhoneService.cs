using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared;
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
        private readonly IMapper _mapper;

        public PhoneService(IRepositoryWrapper repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;

        }

        public IEnumerable<PhoneDto> GetAllPhones(bool trackChanges)
        {
            try
            {
                var phone = _repository.Phone.GetAll(trackChanges);
                var phonesDto = _mapper.Map<IEnumerable<PhoneDto>>(phone);

                return phonesDto;
                

            }
            catch (Exception ex)
            {
                _logger.LogError($"Mas dañino que el azucar: {ex.Message}");
                throw;
            }
        }
    }
}
