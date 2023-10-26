using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grpc.DTOs
{
    public class CageDto
    {
        public string Code { get; set; } = default!;
        public string Location { get; set; } = default!;
        public byte[]? Image { get; set; }
        public int Capacity { get; set; }
        public string? Description { get; set; }
        public int AreaId { get; set; }
        public ICollection<CageHistory> CageHistories { get; set; } = new List<CageHistory>();
        [NotMapped]
        public ICollection<Diet>? Diets { get; set; } = new List<Diet>();
        [NotMapped]
        public string? OveralDiet { get; set; }
    }
}
