using FluentBuilderGenerator.Extensions;
using FluentBuilderGenerator.Models;
using FluentBuilderGenerator.Types;

namespace FluentBuilderGenerator.FileGenerators;

// ReSharper disable once InconsistentNaming
internal class IDictionaryBuilderGenerator : IFileGenerator
{
    private const string Name = "FluentBuilder.IDictionaryBuilder.g.cs";

    private readonly string _assemblyName;
    private readonly bool _supportsNullable;

    public IDictionaryBuilderGenerator(string assemblyName, bool supportsNullable)
    {
        _assemblyName = assemblyName;
        _supportsNullable = supportsNullable;
    }

    public FileData GenerateFile()
    {
        var text =
            $$"""
              {{Header.Text}}

              {{_supportsNullable.IIf("#nullable enable")}}
              using System;
              using System.Collections.Generic;

              namespace {{_assemblyName}}.FluentBuilder
              {
                  public partial class IDictionaryBuilder<TKey, TValue> : Builder<IDictionary<TKey, TValue>>{{(_supportsNullable ? " where TKey : notnull" : string.Empty)}}
                  {
                      private readonly Lazy<IDictionary<TKey, TValue>> _dictionary = new Lazy<IDictionary<TKey, TValue>>(() => new Dictionary<TKey, TValue>());
              
                      public virtual IDictionaryBuilder<TKey, TValue> Add(TKey key, TValue value) => Add(() => new KeyValuePair<TKey, TValue>(key, value));
                      public virtual IDictionaryBuilder<TKey, TValue> Add(Func<KeyValuePair<TKey, TValue>> func)
                      {
                          var result = func();
                          _dictionary.Value.Add(result.Key, result.Value);
              
                          return this;
                      }
              
                      public override IDictionary<TKey, TValue> Build() => Build(true);
              
                      public override IDictionary<TKey, TValue> Build(bool useObjectInitializer)
                      {
                          if (Instance?.IsValueCreated != true)
                          {
                              Instance = new Lazy<IDictionary<TKey, TValue>>(() =>
                              {
                                  return _dictionary.Value;
                              });
                          }
              
                          PostBuild(Instance.Value);
              
                          return Instance.Value;
                      }
                  }
              }
              {{_supportsNullable.IIf("#nullable disable")}}
              """;

        return new FileData
        (
            FileDataType.IDictionaryBuilder,
            Name,
            text
        );
    }
}