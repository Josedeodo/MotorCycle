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
    internal sealed class GarageService : IGarageService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public GarageService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            _repository = repository;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public void createGarage(Garage garage)
        {
            _repository.Garage.CreateGarage(garage);
        }

        public void CreateGarage(Garage garage)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Garage> GetAllGarages(bool trackChanges)
        {
            try
            {

                return _repository.Garage.GetAll(trackChanges);
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Mas dañino que el azucar: {ex.Message}");
                throw;
            }
        }
    }
}
