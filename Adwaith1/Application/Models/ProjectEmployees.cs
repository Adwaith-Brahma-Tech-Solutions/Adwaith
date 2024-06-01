using Spark.Library.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adwaith1.Application.Models
{
    [Table("projectemployees")]
    public class ProjectEmployees : BaseModel
    {
        [Required]
        public int ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public Project Projects { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employees { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsRemoved { get; set; }
        public new int Id { get; set; }
    }
}
