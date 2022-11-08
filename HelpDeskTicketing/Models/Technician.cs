using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace HelpDeskTicketing.Models
{
    [Table("Technicians", Schema = "HD")]
    public class Technician
    {
        [Key]
        [Display(Name = "Technician ID")]
        public int TechnicianId { get; set; }
        [Required]
        [Display(Name = "Technician Name")]
        [Column(TypeName = "varchar(200)")]
        public string TechnicianName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;   
        public string Password { get; set; } = string.Empty;
        public string RoleDescription { get; set; } = string.Empty;
        //Relationships
        public virtual ICollection<Tickets> Tickets { get; set; } = new List<Tickets>();    
    }
}
