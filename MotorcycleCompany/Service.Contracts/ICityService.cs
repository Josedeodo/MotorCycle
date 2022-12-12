using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DTO;

namespace Service.Contracts
{
    public interface ICityService
    {
        IEnumerable<CityDto> GetAllCitiesDTO(bool trackChanges);
        void CreateCity(City city);
    }
}
