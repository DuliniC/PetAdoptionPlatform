using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models.Entities
{
    public class Picture
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public long PetId { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
