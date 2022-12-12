using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Shared.DTO;

namespace Service.Contracts
{
    public interface IGarageService
    {
        IEnumerable<GarageDto> GetAllGarages(bool trackChanges);
    }
}
