//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder version 0.10.0.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
using System;
using System.Collections.Generic;

namespace FluentBuilderGeneratorTests.FluentBuilder
{
    public partial class ICollectionBuilder<T> : Builder<ICollection<T>>
    {
        private readonly Lazy<List<T>> _list = new Lazy<List<T>>(() => new List<T>());

        public ICollectionBuilder<T> Add(T item) => Add(() => item);
        public ICollectionBuilder<T> Add(Func<T> func)
        {
            _list.Value.Add(func());

            return this;
        }

        public override ICollection<T> Build() => Build(true);

        public override ICollection<T> Build(bool useObjectInitializer)
        {
            if (Instance?.IsValueCreated != true)
            {
                Instance = new Lazy<ICollection<T>>(() =>
                {
                    return _list.Value;
                });
            }

            PostBuild(Instance.Value);

            return Instance.Value;
        }
    }
}
#nullable disable