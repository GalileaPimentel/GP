using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM1.Models
{
    [Table("Almacen")]
    public class Almacen
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id {  get; set; }
        public string Domicilio { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }

        public string Foto { get; set; } = "";

        
    }
}
