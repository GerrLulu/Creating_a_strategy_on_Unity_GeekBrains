using Abstractions;
using System.Linq;
using UnityEngine;
using UserControlSystem.UI.Model;

namespace UserControlSystem.UI.Presenter
{
    public class MouseInteractionsPresenter : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private SelectableValueModel _selectedObject;


        private void Update()
        {
            if (!Input.GetMouseButtonUp(0))
                return;

            var hits = Physics.RaycastAll(_camera.ScreenPointToRay(Input.mousePosition));

            if (hits.Length == 0)
                return;

            var mainBuilding = hits
                .Select(hit => hit.collider.GetComponentInParent<IUnitProducer>())
                .Where(c => c != null)
                .FirstOrDefault();

            if (mainBuilding == default)
                return;

            mainBuilding.ProduceUnit();
        }
    }
}