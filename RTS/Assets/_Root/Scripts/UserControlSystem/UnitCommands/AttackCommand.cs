using Abstractions;
using Abstractions.Commands.CommandInterfaces;

namespace UserControlSystem.UnitCommands
{
    public class AttackCommand : IAttackCommand
    {
        public IAttackeble Target { get; }


        public AttackCommand(IAttackeble target) => Target = target;
    }
}