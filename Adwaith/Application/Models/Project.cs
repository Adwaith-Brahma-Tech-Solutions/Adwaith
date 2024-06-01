using Spark.Library.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adwaith.Application.Models
{
    [Table("projects")]
    public class Project : BaseModel
    {
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        [Required]
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public Client Clients { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IsRemoved { get; set; }
        public string UpdatedBy { get; set; }

    }
}
