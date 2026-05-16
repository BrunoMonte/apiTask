using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Data;
using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;



namespace TaskManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TarefasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/tarefas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarefa>>> GetAll()
        {
            var tarefas = await _context.Tarefas.ToListAsync();
            return Ok(tarefas);
        }

        // GET: api/tarefas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarefa>> GetById(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);

            if (tarefa == null)
                return NotFound(new { message = "Tarefa não encontrada" });

            return Ok(tarefa);
        }

        // POST: api/tarefas
        [HttpPost]
        public async Task<ActionResult<Tarefa>> Create(CreateTarefaDto dto)
        {
            var tarefa = new Tarefa
            {
                Title = dto.Title,
                Description = dto.Description,
                Status = dto.Status ?? "Pendente",
                DataCriacao = DateTime.Now
            };

            _context.Tarefas.Add(tarefa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = tarefa.Id }, tarefa);
        }

        // PUT: api/tarefas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Tarefa tarefa)
        {
            if (id != tarefa.Id)
                return BadRequest(new { message = "ID da URL diferente do corpo" });

            var exists = await _context.Tarefas.AnyAsync(t => t.Id == id);
            if (!exists)
                return NotFound(new { message = "Tarefa não encontrada" });

            _context.Entry(tarefa).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/tarefas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);

            if (tarefa == null)
                return NotFound(new { message = "Tarefa não encontrada" });

            _context.Tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}