//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder version 0.9.2.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using FluentBuilderGeneratorTests.FluentBuilder;
using FluentBuilderGeneratorTests.DTO;

namespace FluentBuilderGeneratorTests.DTO
{
    public partial class IReadOnlyCollectionAddressBuilder : Builder<IReadOnlyCollection<FluentBuilderGeneratorTests.DTO.Address>>
    {
        private readonly Lazy<List<FluentBuilderGeneratorTests.DTO.Address>> _list = new Lazy<List<FluentBuilderGeneratorTests.DTO.Address>>(() => new List<FluentBuilderGeneratorTests.DTO.Address>());
        public IReadOnlyCollectionAddressBuilder Add(Address item) => Add(() => item);
        public IReadOnlyCollectionAddressBuilder Add(Func<Address> func)
        {
            _list.Value.Add(func());
            return this;
        }
        public IReadOnlyCollectionAddressBuilder Add(Action<FluentBuilderGeneratorTests.DTO.AddressBuilder> action, bool useObjectInitializer = true)
        {
            var builder = new FluentBuilderGeneratorTests.DTO.AddressBuilder();
            action(builder);
            Add(() => builder.Build(useObjectInitializer));
            return this;
        }


        public override IReadOnlyCollection<FluentBuilderGeneratorTests.DTO.Address> Build() => Build(true);

        public override IReadOnlyCollection<FluentBuilderGeneratorTests.DTO.Address> Build(bool useObjectInitializer)
        {
            if (Instance?.IsValueCreated != true)
            {
                Instance = new Lazy<IReadOnlyCollection<FluentBuilderGeneratorTests.DTO.Address>>(() =>
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