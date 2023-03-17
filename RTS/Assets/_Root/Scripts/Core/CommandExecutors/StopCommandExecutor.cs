using Abstractions.Commands.CommandInterfaces;
using Abstractions.Commands;
using UnityEngine;

namespace Core.CommandExecutors
{
    public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
    {
        public override void ExecuteSpecificCommand(IStopCommand command)
        {
            Debug.Log($"Stope");
        }
    }
}