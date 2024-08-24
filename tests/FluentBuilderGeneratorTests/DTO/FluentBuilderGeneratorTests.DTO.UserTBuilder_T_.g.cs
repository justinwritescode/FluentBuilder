//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder version 0.9.1.0
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
    public static partial class UserTBuilder_T_Extensions
    {
        public static UserTBuilder<T> AsBuilder<T>(this FluentBuilderGeneratorTests.DTO.UserT<T> instance) where T : struct
        {
            return new UserTBuilder<T>().UsingInstance(instance);
        }
    }

    public partial class UserTBuilder<T> : Builder<FluentBuilderGeneratorTests.DTO.UserT<T>> where T : struct
    {
        private bool _tValueIsSet;
        private Lazy<T> _tValue = new Lazy<T>(() => default(T));
        public UserTBuilder<T> WithTValue(T value) => WithTValue(() => value);
        public UserTBuilder<T> WithTValue(Func<T> func)
        {
            _tValue = new Lazy<T>(func);
            _tValueIsSet = true;
            return this;
        }

        private bool _Constructor302462813_IsSet;
        private Lazy<FluentBuilderGeneratorTests.DTO.UserT<T>> _Constructor302462813 = new Lazy<FluentBuilderGeneratorTests.DTO.UserT<T>>(() => new FluentBuilderGeneratorTests.DTO.UserT<T>());
        public UserTBuilder<T> UsingConstructor()
        {
            _Constructor302462813 = new Lazy<FluentBuilderGeneratorTests.DTO.UserT<T>>(() =>
            {
                return new FluentBuilderGeneratorTests.DTO.UserT<T>
                (

                );
            });
            _Constructor302462813_IsSet = true;

            return this;
        }


        public UserTBuilder<T> UsingInstance(UserT<T> value) => UsingInstance(() => value);

        public UserTBuilder<T> UsingInstance(Func<UserT<T>> func)
        {
            Instance = new Lazy<UserT<T>>(func);
            return this;
        }

        public override UserT<T> Build() => Build(true);

        public override UserT<T> Build(bool useObjectInitializer)
        {
            if (Instance is null)
            {
                Instance = new Lazy<UserT<T>>(() =>
                {
                    UserT<T> instance;
                    if (useObjectInitializer)
                    {
                        instance = new UserT<T>
                        {
                            TValue = _tValue.Value
                        };

                        return instance;
                    }

                    if (_Constructor302462813_IsSet) { instance = _Constructor302462813.Value; }
                    else { instance = Default(); }

                    return instance;
                });
            }

            if (_tValueIsSet) { Instance.Value.TValue = _tValue.Value; }

            PostBuild(Instance.Value);

            return Instance.Value;
        }

        public static UserT<T> Default() => new UserT<T>();

    }
}
#nullable disable