using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Spark.Library.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adwaith.Application.Models
{
    [Table("timesheets")]
    public class Timesheet : BaseModel
    {
        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employees { get; set; }
        [Required]
        public int ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public Project Projects { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsRemoved { get; set; }

    }
}
