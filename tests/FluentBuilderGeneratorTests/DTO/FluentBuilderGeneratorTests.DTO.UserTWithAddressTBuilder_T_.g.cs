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
using System.Reflection;
using FluentBuilderGeneratorTests.FluentBuilder;
using FluentBuilderGeneratorTests.DTO;

namespace FluentBuilderGeneratorTests.DTO
{
    public static partial class UserTWithAddressTBuilder_T_Extensions
    {
        public static UserTWithAddressTBuilder<T> AsBuilder<T>(this FluentBuilderGeneratorTests.DTO.UserTWithAddressT<T> instance) where T : struct
        {
            return new UserTWithAddressTBuilder<T>().UsingInstance(instance);
        }
    }

    public partial class UserTWithAddressTBuilder<T> : Builder<FluentBuilderGeneratorTests.DTO.UserTWithAddressT<T>> where T : struct
    {
        private bool _tValueIsSet;
        private Lazy<T> _tValue = new Lazy<T>(() => default(T));
        public UserTWithAddressTBuilder<T> WithTValue(T value) => WithTValue(() => value);
        public UserTWithAddressTBuilder<T> WithTValue(Func<T> func)
        {
            _tValue = new Lazy<T>(func);
            _tValueIsSet = true;
            return this;
        }
        private bool _addressIsSet;
        private Lazy<FluentBuilderGeneratorTests.DTO.Address<short>> _address = new Lazy<FluentBuilderGeneratorTests.DTO.Address<short>>(() => new FluentBuilderGeneratorTests.DTO.Address<short>());
        public UserTWithAddressTBuilder<T> WithAddress(FluentBuilderGeneratorTests.DTO.Address<short> value) => WithAddress(() => value);
        public UserTWithAddressTBuilder<T> WithAddress(Func<FluentBuilderGeneratorTests.DTO.Address<short>> func)
        {
            _address = new Lazy<FluentBuilderGeneratorTests.DTO.Address<short>>(func);
            _addressIsSet = true;
            return this;
        }
        public UserTWithAddressTBuilder<T> WithAddress(Action<FluentBuilderGeneratorTests.DTO.AddressBuilder<short>> action, bool useObjectInitializer = true) => WithAddress(() =>
        {
            var builder = new FluentBuilderGeneratorTests.DTO.AddressBuilder<short>();
            action(builder);
            return builder.Build(useObjectInitializer);
        });

        private bool _Constructor1691800221_IsSet;
        private Lazy<FluentBuilderGeneratorTests.DTO.UserTWithAddressT<T>> _Constructor1691800221 = new Lazy<FluentBuilderGeneratorTests.DTO.UserTWithAddressT<T>>(() => new FluentBuilderGeneratorTests.DTO.UserTWithAddressT<T>());
        public UserTWithAddressTBuilder<T> UsingConstructor()
        {
            _Constructor1691800221 = new Lazy<FluentBuilderGeneratorTests.DTO.UserTWithAddressT<T>>(() =>
            {
                return new FluentBuilderGeneratorTests.DTO.UserTWithAddressT<T>
                (

                );
            });
            _Constructor1691800221_IsSet = true;

            return this;
        }


        public UserTWithAddressTBuilder<T> UsingInstance(UserTWithAddressT<T> value) => UsingInstance(() => value);

        public UserTWithAddressTBuilder<T> UsingInstance(Func<UserTWithAddressT<T>> func)
        {
            Instance = new Lazy<UserTWithAddressT<T>>(func);
            return this;
        }

        public override UserTWithAddressT<T> Build() => Build(true);

        public override UserTWithAddressT<T> Build(bool useObjectInitializer)
        {
            if (Instance is null)
            {
                Instance = new Lazy<UserTWithAddressT<T>>(() =>
                {
                    UserTWithAddressT<T> instance;
                    if (useObjectInitializer)
                    {
                        instance = new UserTWithAddressT<T>
                        {
                            TValue = _tValue.Value,
                            Address = _address.Value
                        };

                        return instance;
                    }

                    if (_Constructor1691800221_IsSet) { instance = _Constructor1691800221.Value; }
                    else { instance = Default(); }

                    return instance;
                });
            }

            if (_tValueIsSet) { Instance.Value.TValue = _tValue.Value; }
            if (_addressIsSet) { Instance.Value.Address = _address.Value; }

            PostBuild(Instance.Value);

            return Instance.Value;
        }

        public static UserTWithAddressT<T> Default() => new UserTWithAddressT<T>();

    }
}
#nullable disable