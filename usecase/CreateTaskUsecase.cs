using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;
using TaskManagerAPI.Repositories.Interfaces;
using TaskManagerAPI.UseCases.Interfaces;

namespace TaskManagerAPI.UseCases
{
    public class CreateTaskUseCase : ICreateTaskUseCase
    {
        private readonly ITaskRepository _taskRepository;

        public CreateTaskUseCase(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<Tarefa> ExecuteAsync(CreateTarefaDto dto)
        {
            await ValidateBusinessRules(dto);

            var tarefa = CreateEntity(dto);

            await _taskRepository.AddAsync(tarefa);

            return tarefa;
        }

        private async Task ValidateBusinessRules(CreateTarefaDto dto)
        {
            // Exemplo:
            // if (await _taskRepository.ExistsByTitleAsync(dto.Title))
            //     throw new Exception("Já existe uma tarefa com esse título.");
        }

        private static Tarefa CreateEntity(CreateTarefaDto dto)
        {
            return new Tarefa
            {
                Title = dto.Title,
                Description = dto.Description,
                DueDate = dto.DueDate,
                Status = TarefaStatus.Pending
            };
        }
    }
}