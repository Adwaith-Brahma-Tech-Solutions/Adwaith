using Spark.Library.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adwaith.Application.Models
{
    [Table("employees")]
    public class Employee : BaseModel
    {

        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string BankAccountNo { get; set; }
        [Required]
        public string IFSC { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string EmailId { get; set; }
        public bool IsRemoved { get; set; }

        public string UpdatedBy { get; set; }
    }
}
