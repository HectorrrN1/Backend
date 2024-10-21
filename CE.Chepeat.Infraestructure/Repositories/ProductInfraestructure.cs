

using CE.Chepeat.Domain.Aggregates.Product;
using CE.Chepeat.Domain.DTOs.Product;

/// Developer : Hector Nuñez Cruz
/// Creation Date : 20/10/2024
/// Creation Description:Infraestrcutura de Producto
/// Update Date : --
/// Update Description : --
///CopyRight: Chepeat
namespace CE.Chepeat.Infraestructure.Repositories
{
    public class ProductInfraestructure : IProductInfraestructure
    {
        private readonly ChepeatContext _context;

        public ProductInfraestructure(ChepeatContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> GetProducts()
        {
            try
            {
                var NumError = new SqlParameter
                {
                    ParameterName = "NumError",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                var Result = new SqlParameter
                {
                    ParameterName = "Result",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Direction = ParameterDirection.Output
                };
                SqlParameter[] parameters = { NumError, Result };
                string sqlQuery = "EXEC dbo.SP_Products_Selection @NumError OUTPUT, @Result OUTPUT";
                var dataSP = await _context.productDto.FromSqlRaw(sqlQuery, parameters).ToListAsync();
                return dataSP;
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public async Task<RespuestaDB> AddProduct(ProductAggregate productAggregate)
        {
            try
            {
                var NumError = new SqlParameter
                {
                    ParameterName = "NumError",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                var Result = new SqlParameter
                {
                    ParameterName = "Result",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Direction = ParameterDirection.Output
                };

                SqlParameter[] parameters =
                {
                new SqlParameter("Name", productAggregate.Name),
                new SqlParameter("Description", productAggregate.Description),
                new SqlParameter("Price", productAggregate.Price),
                new SqlParameter("IdSeller", productAggregate.IdSeller),
                NumError,
                Result
            };
                string sqlQuery = "EXEC dbo.SP_Products_Insert @Name, @Description, @Price, @IdSeller, @NumError OUTPUT, @Result OUTPUT";
                var dataSP = await _context.respuestaDB.FromSqlRaw(sqlQuery, parameters).ToListAsync();
                return dataSP.FirstOrDefault();
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public async Task<RespuestaDB> DeleteProduct(Guid id)
        {
            try
            {
                var NumError = new SqlParameter
                {
                    ParameterName = "NumError",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                var Result = new SqlParameter
                {
                    ParameterName = "Result",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Direction = ParameterDirection.Output
                };
                SqlParameter[] parameters =
                {
                new SqlParameter("Id", id),
                NumError,
                Result
            };
                string sqlQuery = "EXEC dbo.SP_Products_Delete @Id, @NumError OUTPUT, @Result OUTPUT";
                var dataSP = await _context.respuestaDB.FromSqlRaw(sqlQuery, parameters).ToListAsync();
                return dataSP.FirstOrDefault();
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public async Task<RespuestaDB> UpdateProduct(ProductAggregate productAggregate)
        {
            try
            {
                var NumError = new SqlParameter
                {
                    ParameterName = "NumError",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                var Result = new SqlParameter
                {
                    ParameterName = "Result",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Direction = ParameterDirection.Output
                };

                SqlParameter[] parameters =
                {
                new SqlParameter("Id", productAggregate.Id),
                new SqlParameter("Name", productAggregate.Name),
                new SqlParameter("Description", productAggregate.Description),
                new SqlParameter("Price", productAggregate.Price),
                NumError,
                Result
            };
                string sqlQuery = "EXEC dbo.SP_Products_Update @Id, @Name, @Description, @Price, @NumError OUTPUT, @Result OUTPUT";
                var dataSP = await _context.respuestaDB.FromSqlRaw(sqlQuery, parameters).ToListAsync();
                return dataSP.FirstOrDefault();
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}
    