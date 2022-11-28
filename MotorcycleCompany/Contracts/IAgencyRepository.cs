using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public  interface IAgencyRepository : IRepositoryBase<Agency>
    {
        IEnumerable<Agency> GetAll(bool trackChanges);
        IEnumerable<Agency> GetById(Guid id, bool trackChanges);
        void CreateClient(Agency agency);
        void UpdateClient(Agency agency);
        //void UpdateRange(List<T> entity);
        void DeleteClient(Agency agency);

    }
}
