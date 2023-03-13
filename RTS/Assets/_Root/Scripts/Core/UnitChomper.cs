using Abstractions;
using UnityEngine;

namespace Core
{
    public class UnitChomper : MonoBehaviour, ISelecatable
    {
        [SerializeField] private float _maxHealth = 1000;
        [SerializeField] private Sprite _icon;

        private float _health = 1000;
        private Outline _outline;

        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;

        public Outline Outline
        {
            get { return _outline; }
            set { _outline = value; }
        }


        private void Start()
        {
            _outline = gameObject.AddComponent<Outline>();

            _outline.OutlineMode = Outline.Mode.OutlineAll;
            _outline.OutlineColor = Color.green;
            _outline.OutlineWidth = 0f;

            _outline.enabled = false;
        }
    }
}