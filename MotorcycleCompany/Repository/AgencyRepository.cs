using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;

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
            return FindAll(trackChanges).ToList();
        }

        public IEnumerable<Agency> GetById(Guid id, bool trackChanges)
        {

            return FindByCondition(x => x.AgencyId.Equals(id), trackChanges).ToList();
        }

        public void CreateClient(Agency agency) => Create(agency);

        public void UpdateClient(Agency agency) => Update(agency);

        public void DeleteClient(Agency agency) => Delete(agency);

    }
}
