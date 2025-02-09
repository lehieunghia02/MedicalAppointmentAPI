using System.ComponentModel.DataAnnotations.Schema;

namespace Models;
public abstract class BaseEntity
{
  [Column(TypeName = "datetime2(0)")]
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  [Column(TypeName = "datetime2(0)")]
  public DateTime? UpdatedAt { set; get; }
}