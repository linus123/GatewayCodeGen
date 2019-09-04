using Birchy.GatewayCodeGen.Core.Database;

namespace Birchy.GatewayCodeGen.Core.Contracts
{
    public interface IGatewayGenerator
    {
        string GenerateGatewayClass(CodeGenerationConfiguration configuration, DatabaseTableDefinition tableDefinition);
    }
}