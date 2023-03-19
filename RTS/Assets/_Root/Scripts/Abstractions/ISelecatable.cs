using UnityEngine;

namespace Abstractions
{
    public interface ISelecatable : IHealthHolder
    {
        Transform PivotPoint { get; }
        Sprite Icon { get; }
        Outline Outline { get; }
    }
}