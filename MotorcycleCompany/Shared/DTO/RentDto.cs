using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
   public record RentDto (string MotorcycleId, DateTime RentalDate, DateTime ReturnDate, decimal Price, string Paid);
}
