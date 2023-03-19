using Abstractions.Commands.CommandInterfaces;
using System;
using UserControlSystem.UnitCommands;
using Utils.AssetsInjector;
using Zenject;

namespace UserControlSystem.UI.Model.CommandCreators
{
    public class AttackCommandCreator : CommandCreatorBase<IAttackCommand>
    {
        [Inject] private AssetsContext _context;


        protected override void ClassSpecificCommandCreation(Action<IAttackCommand> creationCallback) =>
            creationCallback?.Invoke(_context.Inject(new AttackCommand()));
    }
}