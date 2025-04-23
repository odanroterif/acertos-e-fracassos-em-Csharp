using backend3.data;
using backend3.models;
using Microsoft.AspNetCore.Mvc;

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
    /*
    [HttpGet]
    public async Task<ActionResult<Person>> Viewer()
    {
        return Ok(_context.SimpleCrud.ToList());
    }*/
}