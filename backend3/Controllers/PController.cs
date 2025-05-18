
using backend3.models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend3.Controllers;

[ApiController]
[EnableCors("*")]
[Route("v1/[controller]")]
public class PController : ControllerBase
{
    private readonly AppDbContext _context;

    public PController(AppDbContext context) => _context = context;

    [HttpPost]
    public async Task<IActionResult> Create( [FromBody] Person person)
    {
        if (!ModelState.IsValid)
            BadRequest(ModelState);
        
        _context.SimpleCrud.Add(person);
        await _context.SaveChangesAsync();
        
        return Created("Cadastro Realizado.",person);
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Person>>> ViewerAll() => await _context.SimpleCrud.ToListAsync();
    
    [HttpGet("ordemalfabeto")]
    public async Task<ActionResult<IEnumerable<Person>>> AlphabetOrder() => await _context.SimpleCrud.OrderBy(p => p.Name).ToListAsync();
    
    [HttpGet("gentecomsenha")]
    public async Task<ActionResult<IEnumerable<Person>>> Viewer()
    {
        var personList = await _context.SimpleCrud.Where(p => p.Password != String.Empty).ToListAsync();
        
        return Ok(personList);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Person person)
    {
        if (id != person.Id)
            return BadRequest("A atualização falhou, a pessoa que você busca não existe");

        
        _context.Entry(person).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        
        return Ok(person);
    }
    
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Del(int id)
    {
        var person = await _context.SimpleCrud.FindAsync(id);
        var died = person?.Name;
        
        if (person != null && id != person.Id)
            return NotFound("Aviso: a pessoa que você procura ja foi removida ou não existe");

        
#pragma warning disable CS8604 // Possible null reference argument.
        _context.SimpleCrud.Remove(person);
#pragma warning restore CS8604 // Possible null reference argument.
        await _context.SaveChangesAsync();
        
        return Ok($"{died} foi removida com sucesso!");
    }
}
