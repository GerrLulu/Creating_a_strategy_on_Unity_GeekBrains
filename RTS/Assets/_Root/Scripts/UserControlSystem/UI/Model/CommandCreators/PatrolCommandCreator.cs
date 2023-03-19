using Abstractions.Commands.CommandInterfaces;
using System;
using UserControlSystem.UnitCommands;
using Utils.AssetsInjector;
using Zenject;

namespace UserControlSystem.UI.Model.CommandCreators
{
    public class PatrolCommandCreator : CommandCreatorBase<IPatrolCommand>
    {
        [Inject] private AssetsContext _context;


        protected override void ClassSpecificCommandCreation(Action<IPatrolCommand> creationCallback) =>
            creationCallback?.Invoke(_context.Inject(new PatrolCommand()));
    }
}
