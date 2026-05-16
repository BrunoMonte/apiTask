using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.DTOs
{
    public class CreateTarefaDto
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
    }
}