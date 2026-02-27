using Microsoft.EntityFrameworkCore;
using TarefasAPI.Data;
using TarefasAPI.Models;

namespace TarefasAPI.Repositories
{
    public class RepositoryTarefa : IRepositoryTarefa
    {
        private readonly AppDbContext _context;

        public RepositoryTarefa(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tarefa>> GetAll()
        {
            return await _context.Tarefas.ToListAsync();
        }

        public async Task<Tarefa?> GetById(int id)
        {
            return await _context.Tarefas.FindAsync(id);
        }

        public async Task Add(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var tarefa = await GetById(id);
            if (tarefa != null)
            {
                _context.Tarefas.Remove(tarefa);
                await _context.SaveChangesAsync();
            }
        }
    }
}