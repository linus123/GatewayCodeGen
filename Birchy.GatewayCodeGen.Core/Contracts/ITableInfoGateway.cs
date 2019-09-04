using Birchy.GatewayCodeGen.Core.Database;

namespace Birchy.GatewayCodeGen.Core.Contracts
{
    public interface ITableInfoGateway
    {
        TableInfoDto[] GetAll();
    }
}