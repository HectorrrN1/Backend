

using CE.Chepeat.Domain.Aggregates.Product;
using CE.Chepeat.Domain.DTOs.Product;
/// Developer : Hector Nuñez Cruz
/// Creation Date : 20/10/2024
/// Creation Description:Presenter de Producto
/// Update Date : --
/// Update Description : --
///CopyRight: Chepeat

namespace CE.Chepeat.Application.Presenters
{
    public class ProductPresenter : IProductPresenter
    {
        private readonly IUnitRepository _unitRepository;
        private readonly IMapper _mapper;

        public ProductPresenter(IUnitRepository unitRepository, IMapper mapper)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
        }
        /// <summary>
        /// Consulta un registro de la tabla CE_Products
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductDto>> GetProducts()
        {
            return await _unitRepository.productInfraestructure.GetProducts();
        }
        /// <summary>
        /// Añadir un registro de la tabla CE_Products
        /// </summary>
        /// <returns></returns>

        public async Task<RespuestaDB> AddProduct(ProductAggregate productAggregate)
        {
            return await _unitRepository.productInfraestructure.AddProduct(productAggregate);
        }
        /// <summary>
        /// Borrar un registro de la tabla CE_Products
        /// </summary>
        /// <returns></returns>
        public async Task<RespuestaDB> DeleteProduct(Guid id)
        {
            return await _unitRepository.productInfraestructure.DeleteProduct(id);
        }
        /// <summary>
        /// Actualizar un registro de la tabla CE_Products
        /// </summary>
        /// <returns></returns>
        public async Task<RespuestaDB> UpdateProduct(ProductAggregate productAggregate)
        {
            return await _unitRepository.productInfraestructure.UpdateProduct(productAggregate);
        }
    }
}
