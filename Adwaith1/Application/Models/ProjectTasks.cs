using Spark.Library.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adwaith1.Application.Models
{
    [Table("tasks")]
    public class ProjectTasks : BaseModel
    {

        [Required]
        public string Description { get; set; }
        [Required]
        public int HoursWorked { get; set; }
        [Required]
        public int TimesheetId { get; set; }
        [ForeignKey(nameof(TimesheetId))]
        public Timesheet Timesheets { get; set; }

    }
}
