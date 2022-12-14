using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace HelpDeskTicketing.Models
{
    [Table("Tickets", Schema = "HD")]
    public class Tickets
    {
        [Key]
        [Display(Name = "Ticket ID")]
        public int TicketId { get; set; }
        [Required]
        [Display(Name = "Service ID")]
        public int ServiceId  { get; set; }

        [Display(Name ="Description")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Ticketing Time")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Display(Name = "Employee Info")]
        public int EmpoloyeeId { get; set; }
        [Required]
        [Display(Name = "Response time")]
        public DateTime ResponseTime { get; set; }
        [Required]
        [Display(Name = "Responsible Technician")]
        public int TechnicianId { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [ForeignKey("TechnicianId")]
        public Technician? technician { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee? employee { get; set; }
        [ForeignKey("ServiceId")]
        public Service? service { get; set; }
    }
}
