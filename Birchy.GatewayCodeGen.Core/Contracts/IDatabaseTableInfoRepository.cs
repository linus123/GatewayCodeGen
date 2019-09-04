using Birchy.GatewayCodeGen.Core.Database;

namespace Birchy.GatewayCodeGen.Core.Contracts
{
    public interface IDatabaseTableInfoRepository
    {
        DatabaseTableDefinition[] GetDefinitions(CodeGenerationConfiguration configuration);
    }
}