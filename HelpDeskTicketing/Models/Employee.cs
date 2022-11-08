using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDeskTicketing.Models
{
    [Table("Employees", Schema = "HD")]
    public class Employee
    {
        [Key]
        [Display(Name ="ID")]
        public int EmployeeId { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        [Column(TypeName = "varchar(200)")]
        public string EmployeeName { get; set; }    = string.Empty; 
        public string Email { get; set; }  = string.Empty;
        public string Phone { get; set; } = string.Empty; 
        public string Password { get; set; } = string.Empty;    
        //Relationships
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department? Departments { get; set; } [Required] 

        public virtual ICollection<Tickets>? Tickets { get; set; } 

    }
}
