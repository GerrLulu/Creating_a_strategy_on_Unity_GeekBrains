using Abstractions;
using System;
using System.Collections;
using UnityEngine;
using UserControlSystem.UI.Model;

namespace UserControlSystem.UI.Presenter
{
    public class OutlinePresenter : MonoBehaviour
    {
        [SerializeField] private SelectableValue _selectableValue;

        private ISelecatable _currentSelectable;


        void Start()
        {
            _selectableValue.OnNewValue += OnSelected;

            //var selectableOutline = _selectableValue.CurrentValue.Outline;

            //selectableOutline.OutlineMode = Outline.Mode.OutlineAll;
            //selectableOutline.OutlineColor = Color.green;
            //selectableOutline.OutlineWidth = 5;

            //selectableOutline.enabled = false;

            OnSelected(_selectableValue.CurrentValue);
        }

        private void OnSelected(ISelecatable selecatable)
        {
            if (_currentSelectable == selecatable)
                return;

            _currentSelectable = selecatable;

            if(selecatable != null)
                selecatable.Outline.enabled = true;
            else
                selecatable.Outline.enabled = false;
        }
    }
}