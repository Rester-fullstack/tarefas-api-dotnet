using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TarefasAPI.Models;
using TarefasAPI.Repositories;

namespace TarefasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly IRepositoryTarefa _repo;

        public TarefasController(IRepositoryTarefa repo)
        {
            _repo = repo;
        }

        // GET: api/tarefas
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repo.GetAll());
        }

        // GET: api/tarefas/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tarefa = await _repo.GetById(id);

            if (tarefa == null)
                return NotFound();

            return Ok(tarefa);
        }

        // POST: api/tarefas
        [HttpPost]
        public async Task<IActionResult> Create(Tarefa tarefa)
        {
            await _repo.Add(tarefa);
            return Ok();
        }

        // PUT: api/tarefas
        [HttpPut]
        public async Task<IActionResult> Update(Tarefa tarefa)
        {
            await _repo.Update(tarefa);
            return Ok();
        }

        // DELETE: api/tarefas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repo.Delete(id);
            return Ok();
        }

     }
}

