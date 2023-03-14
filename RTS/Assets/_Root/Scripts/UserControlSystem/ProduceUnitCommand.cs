using Abstractions.Commands.CommandInterfaces;
using UnityEngine;
using Utils.AssetsInjector;

namespace UserControlSystem
{
    public class ProduceUnitCommand : IProduceUnitCommand
    {
        [InjectAsset("Chomper")] private GameObject _unitPrefab;

        public GameObject UnitPrefab => _unitPrefab;
    }
}
