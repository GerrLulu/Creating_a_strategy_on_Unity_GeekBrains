using Abstractions.Commands.CommandInterfaces;
using System.Threading.Tasks;
using UnityEngine;

namespace Core.CommandExecutors
{
    public class AttackCommandExecutor : CommandExecutorBase<IAttackCommand>
    {
        public override async Task ExecuteSpecificCommand(IAttackCommand command)
        {
            Debug.Log($"Attack!!!1111!!!11!11 {command.Target}");
        }
    }
}