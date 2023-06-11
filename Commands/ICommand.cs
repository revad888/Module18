namespace Module18.Commands;

interface ICommand
{
    public void Execute();
    public void Undo();
}