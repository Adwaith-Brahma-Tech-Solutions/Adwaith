using Spark.Library.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adwaith1.Application.Models
{
    [Table("clients")]
    public class Client : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string EmailId { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsRemoved { get; set; }

    }
}
