using CE.Chepeat.Domain.Aggregates.Product;
using CE.Chepeat.Domain.DTOs.Product;

/// Developer : Hector Nuñez Cruz
/// Creation Date : 20/10/2024
/// Creation Description:Interfaz de Producto
/// Update Date : --
/// Update Description : --
///CopyRight: Chepeat
namespace CE.Chepeat.Domain.Interfaces.Infraestructure
{
    public interface IProductInfraestructure
    {
        /// <summary>
        /// Consulta todos los registros de la tabla Products
        /// </summary>
        Task<List<ProductDto>> GetProducts();

        /// <summary>
        /// Crear un registro en Products
        /// </summary>
        Task<RespuestaDB> AddProduct(ProductAggregate productAggregate);

        /// <summary>
        /// Eliminar un registro de Products
        /// </summary>
        Task<RespuestaDB> DeleteProduct(Guid id);

        /// <summary>
        /// Actualizar un registro de Products
        /// </summary>
        Task<RespuestaDB> UpdateProduct(ProductAggregate productAggregate);
    }
}
