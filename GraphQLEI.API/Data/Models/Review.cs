using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraphQLEI.API.Data.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public required int Rate { get; set; }

        public required string Comment { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public required Employee Employee { get; set; }
    }
}
