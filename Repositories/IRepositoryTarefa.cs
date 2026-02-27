using TarefasAPI.Models;

namespace TarefasAPI.Repositories
{
    public interface IRepositoryTarefa
    {
        Task<List<Tarefa>> GetAll();
        Task<Tarefa?> GetById(int id);
        Task Add(Tarefa tarefa);
        Task Update(Tarefa tarefa);
        Task Delete(int id);
    }
}