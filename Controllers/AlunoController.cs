using API.appDbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AlunoController : ControllerBase
    {
        private readonly appDbContext _context;
        private object aluno;

        public AlunoController(appDbContext context)
        {
            _context = context;
        }
       
        [HttpGet]
        public async Task<ActionResult<List<Aluno>>> GetAlunos()
        {
            return Ok(await _context.Alunos.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetAluno(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null)
            {
                return BadRequest("Aluno não encontrado");
            }
            return Ok(aluno);
        }

        [HttpPost]
        public async Task<ActionResult<Aluno>> PostAluno(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAluno), new { id = aluno.Id }, aluno);
        }
         
        [HttpPut("{id}")]
        public async Task<ActionResult<Aluno>> PutAluno(int id, Aluno aluno)
        {
            if (id != aluno.Id)
               return BadRequest("ID do aluno não corresponde ao ID fornecido.");
            
            _context.Entry(aluno).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok (aluno);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Aluno>> DeleteAluno(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null)
            
                return BadRequest("Aluno não encontrado");
            
            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();

            return Ok(aluno);
        }
    }
}
