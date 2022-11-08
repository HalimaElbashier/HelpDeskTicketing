using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDeskTicketing.Models
{
    [Table("Departments", Schema = "HD")]
    public class Department
    {
        [Key]
        [Display(Name ="Department ID")]
        public int DepartmentId { get; set; } 
        [Required]
        [Display(Name ="Department Name")]
        [Column(TypeName ="varchar(200)")]
        public string DepartmentName { get; set; } = string.Empty;
        //Relationships
       
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();    
    }
}
