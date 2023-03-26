using Abstractions.Commands.CommandInterfaces;
using System.Threading.Tasks;
using UnityEngine;

namespace Core.CommandExecutors
{
    public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
    {
        public override async Task ExecuteSpecificCommand(IPatrolCommand command)
        {
            Debug.Log($"Patrol from: {command.From} to {command.To}");
        }
    }
}