using System.Collections.Generic;
using UniRx;

namespace uFrame.ECS
{
    public interface IEcsComponentManagerOf<TComponentType> : IEcsComponentManager
    {
        TComponentType this[int entityId] { get; }
        IEnumerable<TComponentType> Components { get; }
        IObservable<TComponentType> CreatedObservable { get; }
        IObservable<TComponentType> RemovedObservable { get; }
    }
}