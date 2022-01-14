namespace Patterns.CommandPattern.Commands
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
