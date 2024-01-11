using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class UserEventTable
    {
        public long UserId { get; set; }
        public long EventId { get; set; }

    }
}
