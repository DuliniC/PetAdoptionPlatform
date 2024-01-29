using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models.Entities
{
    [Keyless]
    public class UserEventTable
    {
        public long UserId { get; set; }
        public long EventId { get; set; }

    }
}
