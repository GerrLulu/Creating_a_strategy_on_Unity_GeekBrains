using Abstractions;
using System;
using UnityEngine;

namespace UserControlSystem.UI.Model
{
    [CreateAssetMenu(fileName = nameof(AttackableValue), menuName = "Strategy Game/" + nameof(AttackableValue), order = 0)]
    public class AttackableValue : ScriptableObject
    {
        public IAttackeble CurrentValue { get; private set; }

        public event Action<IAttackeble> OnAttacked;


        public void SetValue(IAttackeble value)
        {
            CurrentValue = value;
            OnAttacked?.Invoke(value);
        }

    }
}