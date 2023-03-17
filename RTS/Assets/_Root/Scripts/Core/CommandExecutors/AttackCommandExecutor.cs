using Abstractions.Commands.CommandInterfaces;
using Abstractions.Commands;
using UnityEngine;

namespace Core.CommandExecutors
{
    public class AttackCommandExecutor : CommandExecutorBase<IAttackCommand>
    {
        public override void ExecuteSpecificCommand(IAttackCommand command)
        {
            Debug.Log($"Attack!!!1111!!!11!11");
        }
    }
}