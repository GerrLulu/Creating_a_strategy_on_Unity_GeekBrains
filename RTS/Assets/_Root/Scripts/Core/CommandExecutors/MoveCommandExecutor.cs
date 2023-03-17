using Abstractions.Commands;
using Abstractions.Commands.CommandInterfaces;
using UnityEngine;

namespace Core.CommandExecutors
{
    public class MoveCommandExecutor : CommandExecutorBase<IMoveCommand>
    {
        public override void ExecuteSpecificCommand(IMoveCommand command)
        {
            Debug.Log("Move");
        }
    }
}
