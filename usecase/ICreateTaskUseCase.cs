using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.UseCases.Interfaces
{
    public interface ICreateTaskUseCase
    {
        Task<Tarefa> ExecuteAsync(CreateTarefaDto dto);
    }
}