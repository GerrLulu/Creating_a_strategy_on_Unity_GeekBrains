using Abstractions.Commands;
using Abstractions.Commands.CommandInterfaces;
using UnityEngine.AI;

namespace Core.CommandExecutors
{
    public class MoveCommandExecutor : CommandExecutorBase<IMoveCommand>
    {
        public override void ExecuteSpecificCommand(IMoveCommand command)
        {
            GetComponent<NavMeshAgent>().destination = command.Target;
        }
    }
}