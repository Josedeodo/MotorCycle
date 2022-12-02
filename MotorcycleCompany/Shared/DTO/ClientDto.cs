using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record ClientDto(
        string Number,
        string FirstName,
        string LastName,
        string Address,
        string Phone,
        string E_Mail
        );
}


