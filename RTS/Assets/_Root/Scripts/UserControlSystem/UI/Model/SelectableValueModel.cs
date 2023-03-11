using Abstractions;
using System;
using UnityEngine;

namespace UserControlSystem.UI.Model
{
    [CreateAssetMenu(fileName = nameof(SelectableValueModel), menuName = "Strategy Game/" + nameof(SelectableValueModel), order = 0)]
    public class SelectableValueModel : ScriptableObject
    {
        public ISelecatable CurrentValue { get; private set; }

        public Action<ISelecatable> OnSelected;


        public void SetValue(ISelecatable value)
        {
            CurrentValue = value;
            OnSelected?.Invoke(value);
        }

    }
}
