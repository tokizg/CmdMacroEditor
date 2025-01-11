using Cysharp.Threading.Tasks;
public interface IExecutable
{
    UniTaskVoid Run(IExecutableArgument[] arguments);
}