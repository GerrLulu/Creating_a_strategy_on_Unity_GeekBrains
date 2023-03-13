using TMPro;
using Abstractions;
using UnityEngine;
using UnityEngine.UI;
using UserControlSystem.UI.Model;

namespace UserControlSystem.UI.Presenter
{
    public class SelectableUIPresenter : MonoBehaviour
    {
        [SerializeField] private Image _selectedImage;

        [SerializeField] private TextMeshProUGUI _text;

        [SerializeField] private Slider _healthSlider;
        [SerializeField] private Image _sliderBackground;
        [SerializeField] private Image _sliderFillImage;

        [SerializeField] private SelectableValue _selectedValue;
        private Outline _outline;


        private void Start()
        {
            _selectedValue.OnSelected += OnSelected;
            OnSelected(_selectedValue.CurrentValue);
        }


        private void OnSelected(ISelecatable selected)
        {
            _selectedImage.enabled = selected != null;
            _healthSlider.gameObject.SetActive(selected != null);
            _text.enabled = selected != null;

            if (selected != null)
            {
                _selectedImage.sprite = selected.Icon;

                _text.text = $"{selected.Health}/{selected.MaxHealth}";

                _healthSlider.minValue = 0;
                _healthSlider.maxValue = selected.MaxHealth;
                _healthSlider.value = selected.Health;
                var colorSlider = Color.Lerp(Color.red, Color.green, selected.Health / (float)selected.MaxHealth);
                _sliderBackground.color = colorSlider * 0.5f;
                _sliderFillImage.color = colorSlider;

                selected.Outline.enabled = true;
            }
        }
    }

}
