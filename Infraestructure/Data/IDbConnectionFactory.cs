using System.Data;

namespace InventarySystem.Infraestructure.Data
{
    public interface IDbConnectionFactory
    {
        Task<IDbConnection> CreateOpenConnectionAsync();
    }
}