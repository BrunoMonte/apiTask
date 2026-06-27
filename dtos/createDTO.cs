using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.DTOs
{
    public class CreateTarefaDto
    {
        [Required(ErrorMessage = "É obrigatório conter um título para a tarefa.")]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public string Status { get; set; }
    }
}