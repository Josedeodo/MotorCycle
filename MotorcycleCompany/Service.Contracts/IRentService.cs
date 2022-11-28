using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Service.Contracts
{
    public interface IRentService
    {
<<<<<<< HEAD
        void createRent(Rent rent);
=======
        IEnumerable<Rent> GetAllRents(bool trackChanges);
>>>>>>> 3e30cfa57cba9d1259991d16abf21a97dacae9cb
    }
}
