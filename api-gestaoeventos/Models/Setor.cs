using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_gestaoeventos.Models
{
  
    [Table("Setores")]
        public class Setor
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string NomeSetor { get; set; }

            [Required]
            public int GestaoEventoId { get; set; }

            public GestaoEvento GestaoEvento { get; set; }
        }
}

