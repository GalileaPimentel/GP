
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM1.Models
{
    [Table("Estambres")]
    public class Estambres
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Color { get; set; }
        public int Peso { get; set; }

        public string Foto { get; set; } = "";

    }
}
