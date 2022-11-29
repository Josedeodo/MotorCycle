using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
   public record AgencyDto(
       Guid AgencyId,
       string Address,
       string Neighborhood,
       string Location,
       string Name       
    );
}
