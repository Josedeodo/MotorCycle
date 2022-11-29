using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
   public record AgencyDto(
       string Address,
       string Neighborhood,
       string Location,
       string Name,
       ICollection<PhoneDto> Phones
    );
}
