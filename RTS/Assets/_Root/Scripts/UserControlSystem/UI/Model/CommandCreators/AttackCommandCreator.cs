using Abstractions;
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

        private Action<IAttackCommand> _creationCallback;


        [Inject]
        private void Init(AttackableValue groundClicks)
        {
            groundClicks.OnNewValue += OnAttacked;
        }

        private void OnAttacked(IAttackeble attackeble)
        {
            _creationCallback?.Invoke(_context.Inject(new AttackCommand(attackeble)));
            _creationCallback = null;
        }


        protected override void ClassSpecificCommandCreation(Action<IAttackCommand> creationCallback) =>
            _creationCallback = creationCallback;

        public override void ProcessCancel()
        {
            base.ProcessCancel();

            _creationCallback = null;
        }
    }
}