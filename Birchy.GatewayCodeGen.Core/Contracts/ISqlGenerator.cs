using Birchy.GatewayCodeGen.Core.Database;

namespace Birchy.GatewayCodeGen.Core.Contracts
{
    public interface ISqlGenerator
    {
        string GenerateSelect(DatabaseTableDefinition tableDefitition);
        string GenerateInsert(DatabaseTableDefinition tableDefitition);
    }
}