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
    public static partial class ClassWithPrivateSetter1BuilderExtensions
    {
        public static ClassWithPrivateSetter1Builder AsBuilder(this FluentBuilderGeneratorTests.DTO.ClassWithPrivateSetter1 instance)
        {
            return new ClassWithPrivateSetter1Builder().UsingInstance(instance);
        }
    }

    public partial class ClassWithPrivateSetter1Builder : Builder<FluentBuilderGeneratorTests.DTO.ClassWithPrivateSetter1>
    {
        private bool _value2IsSet;
        private Lazy<int> _value2 = new Lazy<int>(() => default(int));
        public ClassWithPrivateSetter1Builder WithValue2(int value) => WithValue2(() => value);
        public ClassWithPrivateSetter1Builder WithValue2(Func<int> func)
        {
            _value2 = new Lazy<int>(func);
            _value2IsSet = true;
            return this;
        }
        private bool _value1IsSet;
        private Lazy<int> _value1 = new Lazy<int>(() => default(int));
        public ClassWithPrivateSetter1Builder WithValue1(int value) => WithValue1(() => value);
        public ClassWithPrivateSetter1Builder WithValue1(Func<int> func)
        {
            _value1 = new Lazy<int>(func);
            _value1IsSet = true;
            return this;
        }

        private bool _Constructor126242367_IsSet;
        private Lazy<FluentBuilderGeneratorTests.DTO.ClassWithPrivateSetter1> _Constructor126242367 = new Lazy<FluentBuilderGeneratorTests.DTO.ClassWithPrivateSetter1>(() => new FluentBuilderGeneratorTests.DTO.ClassWithPrivateSetter1());
        public ClassWithPrivateSetter1Builder UsingConstructor()
        {
            _Constructor126242367 = new Lazy<FluentBuilderGeneratorTests.DTO.ClassWithPrivateSetter1>(() =>
            {
                return new FluentBuilderGeneratorTests.DTO.ClassWithPrivateSetter1
                (

                );
            });
            _Constructor126242367_IsSet = true;

            return this;
        }


        private void SetValue1(ClassWithPrivateSetter1 instance, int value)
        {
            InstanceType.GetProperty("Value1")?.SetValue(instance, value);
        }

        public ClassWithPrivateSetter1Builder UsingInstance(ClassWithPrivateSetter1 value) => UsingInstance(() => value);

        public ClassWithPrivateSetter1Builder UsingInstance(Func<ClassWithPrivateSetter1> func)
        {
            Instance = new Lazy<ClassWithPrivateSetter1>(func);
            return this;
        }

        public override ClassWithPrivateSetter1 Build() => Build(true);

        public override ClassWithPrivateSetter1 Build(bool useObjectInitializer)
        {
            if (Instance is null)
            {
                Instance = new Lazy<ClassWithPrivateSetter1>(() =>
                {
                    ClassWithPrivateSetter1 instance;
                    if (useObjectInitializer)
                    {
                        instance = new ClassWithPrivateSetter1
                        {
                            Value2 = _value2.Value
                        };
                        if (_value1IsSet) { SetValue1(instance, _value1.Value); }
                        return instance;
                    }

                    if (_Constructor126242367_IsSet) { instance = _Constructor126242367.Value; }
                    else { instance = Default(); }

                    return instance;
                });
            }

            if (_value2IsSet) { Instance.Value.Value2 = _value2.Value; }
            if (_value1IsSet) { SetValue1(Instance.Value, _value1.Value); }
            PostBuild(Instance.Value);

            return Instance.Value;
        }

        public static ClassWithPrivateSetter1 Default() => new ClassWithPrivateSetter1();

    }
}
#nullable disable