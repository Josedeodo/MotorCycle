﻿using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{ 
    public record PhoneDto(string NumberPhone, Guid ClientId, Guid AgencyId, DateTime ReservationDate);
 
}
