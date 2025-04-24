using backend3.data;
using backend3.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend3.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class PController : ControllerBase
{
    private readonly AppDbContext _context;

    public PController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<Person>> Create(Person person)
    {
        _context.SimpleCrud.Add(person);
        await _context.SaveChangesAsync();
        
        return Ok(person);
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Person>>> ViewerAll()
    {
        var personList = await _context.SimpleCrud.ToListAsync();
        
        return Ok(personList);
    }
    
    [HttpGet("ordemalfabeto")]
    public async Task<ActionResult<IEnumerable<Person>>> AlphabetOrder()
    {
        var personList = await _context.SimpleCrud.OrderBy(p => p.Name).ToListAsync();
        
        return Ok(personList);
    }
    
    [HttpGet("gentesemsenha")]
    public async Task<ActionResult<IEnumerable<Person>>> Viewer()
    {
        var personList = await _context.SimpleCrud.Where(p => p.Password != "").ToListAsync();
        
        return Ok(personList);
    }
    
    [HttpPut("{id}")]
    public async Task<ActionResult<Person>> Update(int id, Person person)
    {
        if (id != person.Id)
        {
            return BadRequest("A atualização falhou, a pessoa que você busca não existe");
        }
        
        _context.Entry(person).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        
        return Ok(person);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<Person>> Del(int id, Person person)
    {
        if (id != person.Id)
        {
            return BadRequest("Aviso: a pessoa que você procura ja foi removida ou não existe");
        }
        _context.SimpleCrud.Remove(person);
        await _context.SaveChangesAsync();
        
        return Ok(person);
    }
}
