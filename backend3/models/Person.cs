using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend3.models;


[Table("pessoa")]
public class Person
{
    [Column("idpessoa")]
    public int Id { get; set; }
    
    [Required]
    [Column("nome")]
    public string Name { get; set; } = string.Empty;
    
    [Column("senha")]
    public string? Password { get; set; }
}