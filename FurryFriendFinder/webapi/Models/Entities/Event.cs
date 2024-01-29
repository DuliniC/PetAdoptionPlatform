using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class Event
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public int? LocationId { get; set; }
        public string Description { get; set; }
        public virtual Location? Location {get; set; }
    }
}
