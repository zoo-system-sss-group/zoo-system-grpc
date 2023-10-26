using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Entities;
public class BaseEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonPropertyOrder(order: -1)] // not working :(
    public int Id { get; set; }
    
    public DateTime? CreationDate { get; set; } = DateTime.Now;
    
    public DateTime? ModificationDate { get; set; } = DateTime.Now;
   
    public DateTime? DeletionDate { get; set; }
   
    public bool IsDeleted { get; set; } = false;
}
