using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using api_gestaoeventos.Models.api_cursos.Models;

namespace api_gestaoeventos.Models
{
  
        [Table("GestaoEventos")]
        public class GestaoEvento
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public string NomeEvento { get; set; }

            [Required]
            public string Descricao { get; set; }

            [Required]
            public DateTime DataInicio { get; private set; }

            [Required]
            public DateTime DataFim { get; set; }

            // Alterado para relação 1-para-1 com Curso
            [Required]
            public Curso Curso { get; set; }

            // Alterado para relação 1-para-1 com Setor
            [Required]
            public Setor Setor { get; set; }
        }
    
}
