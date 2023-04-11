using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Domain.Models;

public class HelloWorldResponse
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid UserId { get; set; }
    public string UserName { get; set; } = default!;
    public int Level { get; set; }
}