namespace Birchy.GatewayCodeGen.Core.Contracts
{
    public interface ICodeGenerationRepository
    {
        GeneratedDataAccessLayer GenerateDataAccessLayer(CodeGenerationConfiguration configuration);
        GeneratedCode[] GenerateCode(CodeGenerationConfiguration configuration);
    }
}