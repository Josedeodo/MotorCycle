using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IAgencyService
    {
        IEnumerable<Agency> GetAllAgencies(bool trackChanges);
        IEnumerable<Agency> GetAllIncludeRentAndClient(bool trackChanges);

        void CreateAgency (Agency agency);
    }
}
