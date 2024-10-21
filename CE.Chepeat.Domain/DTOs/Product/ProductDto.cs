/// Developer : Hector Nuñez Cruz
/// Creation Date : 20/10/2024
/// Creation Description:DTO de Producto
/// Update Date : --
/// Update Description : --
///CopyRight: Chepeat
namespace CE.Chepeat.Domain.DTOs.Product
{
    public class ProductDto
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string Name { get; set; }

        [Required]
        [MaxLength(512)]
        public string Description { get; set; }

        [Required]
        [Range(0, 9999999.99)]
        public decimal Price { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdatedAt { get; set; }

        public Guid IdSeller { get; set; }
    }
}
