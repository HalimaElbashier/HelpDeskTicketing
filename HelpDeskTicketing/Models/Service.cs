using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDeskTicketing.Models
{
    [Table("Services", Schema = "HD")]
    public class Service
    {
        [Key]
        [Display(Name = "Service ID")]
        public int ServiceId { get; set; }
        [Required]
        [Display(Name = "Service Name")]
        [Column(TypeName = "varchar(200)")]
        public string ServiceName { get; set; } = string.Empty; 

        //RelationShips
        public virtual ICollection<Tickets> Tickets { get; set; } = new List<Tickets>();    
    }
}
