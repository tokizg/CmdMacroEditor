public interface IExecutableSheet
{
    IExecutable GetCurrent();
    bool MoveNext();
    bool MoveDown();
    bool MoveUp();
    void Reset();
}