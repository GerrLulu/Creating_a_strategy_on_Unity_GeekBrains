using Abstractions.Commands;
using Abstractions.Commands.CommandInterfaces;
using UnityEngine;

namespace Assets._Root.Scripts.Core.CommandExecutors
{
    public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
    {
        public override void ExecuteSpecificCommand(IPatrolCommand command)
        {
            Debug.Log("Patrol");
        }
    }
}