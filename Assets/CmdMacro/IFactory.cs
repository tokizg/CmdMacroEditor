public interface IFactory
{
    IExecutable Generate(string identifierSource, string[] argumentSources);
}