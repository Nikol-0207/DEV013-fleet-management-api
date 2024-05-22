using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fleet_Management_API.Model
{
    [Table("trajectories")]
    public class Trajectory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [ForeignKey("Taxi")]
        [Column("taxi_id")]
        public int TaxiId { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("latitude")]
        public double Latitude { get; set; }
        [Column("longitud")]
        public double Longitude { get; set; }
        [JsonIgnore]
        public Taxi Taxi { get; set; }
    }
}
