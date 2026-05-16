using System;


namespace TaskManagerAPI.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; } // Pendente / Concluída

        public DateTime DataCriacao { get; set; }
    }
}