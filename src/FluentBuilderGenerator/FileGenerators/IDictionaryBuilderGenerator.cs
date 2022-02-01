using FluentBuilderGenerator.Models;
using FluentBuilderGenerator.Types;

namespace FluentBuilderGenerator.FileGenerators;

// ReSharper disable once InconsistentNaming
internal class IDictionaryBuilderGenerator : IFileGenerator
{
    private const string Name = "FluentBuilder.IDictionaryBuilder.g.cs";

    private readonly bool _supportsNullable;

    public IDictionaryBuilderGenerator(bool supportsNullable)
    {
        _supportsNullable = supportsNullable;
    }

    public FileData GenerateFile()
    {
        return new FileData
        (
            FileDataType.IDictionaryBuilder,
            Name,
            $@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

{(_supportsNullable ? "#nullable enable" : string.Empty)}
using System;
using System.Collections.Generic;

namespace FluentBuilder
{{
    public partial class IDictionaryBuilder<TKey, TValue> : Builder<IDictionary<TKey, TValue>>{(_supportsNullable ? " where TKey : notnull" : string.Empty)}
    {{
        protected readonly Lazy<IDictionary<TKey, TValue>> _dictionary = new Lazy<IDictionary<TKey, TValue>>(() => new Dictionary<TKey, TValue>());

        public virtual IDictionaryBuilder<TKey, TValue> Add(TKey key, TValue value) => Add(() => new KeyValuePair<TKey, TValue>(key, value));
        public virtual IDictionaryBuilder<TKey, TValue> Add(Func<KeyValuePair<TKey, TValue>> func)
        {{
            var result = func();
            _dictionary.Value.Add(result.Key, result.Value);

            return this;
        }}

        public override IDictionary<TKey, TValue> Build(bool useObjectInitializer = true)
        {{
            if (Object?.IsValueCreated != true)
            {{
                Object = new Lazy<IDictionary<TKey, TValue>>(() =>
                {{
                    return _dictionary.Value;
                }});
            }}

            PostBuild(Object.Value);

            return Object.Value;
        }}
    }}
}}
{(_supportsNullable ? "#nullable disable" : string.Empty)}"
        );
    }
}