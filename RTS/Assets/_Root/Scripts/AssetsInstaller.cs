using Abstractions;
using UnityEngine;
using UserControlSystem.UI.Model;
using Utils;
using Utils.AssetsInjector;
using Zenject;

[CreateAssetMenu(fileName = "AssetsInstaller", menuName = "Installers/AssetsInstaller")]
public class AssetsInstaller : ScriptableObjectInstaller<AssetsInstaller>
{
    [SerializeField] private AssetsContext _legacyContext;
    [SerializeField] private Vector3Value _vector3Value;
    [SerializeField] private AttackableValue _attackable;
    [SerializeField] private SelectableValue _selectabl;


    public override void InstallBindings()
    {
        Container.BindInstances(_legacyContext, _vector3Value, _attackable, _selectabl);
        Container.Bind<IAwaitable<IAttackable>>().FromInstance(_attackable);
        Container.Bind<IAwaitable<Vector3>>().FromInstance(_vector3Value);
    }
}