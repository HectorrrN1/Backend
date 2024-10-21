/// Developer : Hector Nuñez Cruz
/// Creation Date : 20/10/2024
/// Creation Description:DTO de Producto
/// Update Date : --
/// Update Description : --
///CopyRight: Chepeat
namespace CE.Chepeat.Domain.Aggregates.Product
{
    public class ProductAggregate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid IdSeller { get; set; }
    }
}
