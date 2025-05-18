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
    [MaxLength(30)]
    public string Name { get; set; } = string.Empty;
    
    [Column("senha")]
    [MaxLength(40)]
    public string? Password { get; set; }
}
