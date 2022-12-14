using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IAgencyService
    {
        IEnumerable<AgencyDto> GetAllAgenciesDTO(bool trackChanges);
    }
}
