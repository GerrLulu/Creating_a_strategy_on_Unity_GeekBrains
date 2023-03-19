namespace Abstractions.Commands.CommandInterfaces
{
    public interface IAttackCommand : ICommand
    {
        public IAttackeble Target { get; }
    }
}
