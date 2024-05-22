using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fleet_Management_API.Model
{
    [Table("taxis")]
    public class Taxi
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("plate")]
        public string Plate { get; set; }

    }
}
