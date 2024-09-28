using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_gestaoeventos.Models
{
    namespace api_cursos.Models
    {
        [Table("Cursos")]
        public class Curso
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string NomeCurso { get; set; }

            [Required]
            public int GestaoEventoId { get; set; }

            public GestaoEvento GestaoEvento { get; set; }


        }
    }
}
