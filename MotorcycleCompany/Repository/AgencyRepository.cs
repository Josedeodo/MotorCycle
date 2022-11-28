using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AgencyRepository :RepositoryBase<Agency>, IAgencyRepository
    {
        public AgencyRepository(RepositoryContext context) 
            : base(context)
        {
        }
        public IEnumerable<Agency> GetAll(bool trackChanges)
        {    
              return FindAll(trackChanges).Include("Phones").Include("Rents").ToList();
          
        }


        public IEnumerable<Agency> GetById(Guid id, bool trackChanges)
        {

            return FindByCondition(x => x.AgencyId.Equals(id), trackChanges).ToList();
        }

        public void CreateClient(Agency agency) => Create(agency);

        public void UpdateClient(Agency agency) => Update(agency);

        public void DeleteClient(Agency agency) => Delete(agency);


        public IEnumerable<Agency> GetIncludePhone(bool trackChanges)
        {
            return FindAll(trackChanges).Include("Phones").ToList();
        }

        public IEnumerable<Agency> GetIncludeRentAndClient(bool trackChanges)
        {
            return FindAll(trackChanges).Include(x => x.Rents)
     .ThenInclude(x => x.Client).Include(x => x.Phones);
        }

        public IEnumerable<Agency> GetAgencies(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }
    }
}
