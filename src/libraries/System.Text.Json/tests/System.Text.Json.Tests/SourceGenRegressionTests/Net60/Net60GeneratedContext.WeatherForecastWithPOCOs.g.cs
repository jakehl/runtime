﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Source files represent a source generated JsonSerializerContext as produced by the .NET 6 SDK.
// Used to validate correctness of contexts generated by previous SDKs against the current System.Text.Json runtime components.
// Unless absolutely necessary DO NOT MODIFY any of these files -- it would invalidate the purpose of the regression tests.

// <auto-generated/>
#nullable enable

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0618

namespace System.Text.Json.Tests.SourceGenRegressionTests.Net60
{
    public partial class Net60GeneratedContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs>? _WeatherForecastWithPOCOs;
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs> WeatherForecastWithPOCOs
        {
            get
            {
                if (_WeatherForecastWithPOCOs == null)
                {
                    global::System.Text.Json.Serialization.JsonConverter? customConverter;
                    if (Options.Converters.Count > 0 && (customConverter = GetRuntimeProvidedCustomConverter(typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs))) != null)
                    {
                        _WeatherForecastWithPOCOs = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateValueInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs>(Options, customConverter);
                    }
                    else
                    {
                        global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs> objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs>()
                        {
                            ObjectCreator = static () => new global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs(),
                            ObjectWithParameterizedConstructorCreator = null,
                            PropertyMetadataInitializer = WeatherForecastWithPOCOsPropInit,
                            ConstructorParameterMetadataInitializer = null,
                            NumberHandling = default,
                            SerializeHandler = WeatherForecastWithPOCOsSerializeHandler
                        };
            
                        _WeatherForecastWithPOCOs = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs>(Options, objectInfo);
                    }
                }
        
                return _WeatherForecastWithPOCOs;
            }
        }
        
        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] WeatherForecastWithPOCOsPropInit(global::System.Text.Json.Serialization.JsonSerializerContext context)
        {
            global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.Net60GeneratedContext jsonContext = (global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.Net60GeneratedContext)context;
            global::System.Text.Json.JsonSerializerOptions options = context.Options;
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[7];
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.DateTimeOffset> info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.DateTimeOffset>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs),
                PropertyTypeInfo = jsonContext.DateTimeOffset,
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).Date,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).Date = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "Date",
                JsonPropertyName = null
            };
        
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.DateTimeOffset>(options, info0);
            
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Int32> info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Int32>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs),
                PropertyTypeInfo = jsonContext.Int32,
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).TemperatureCelsius,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).TemperatureCelsius = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "TemperatureCelsius",
                JsonPropertyName = null
            };
        
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Int32>(options, info1);
            
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String> info2 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs),
                PropertyTypeInfo = jsonContext.String,
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).Summary!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).Summary = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "Summary",
                JsonPropertyName = null
            };
        
            properties[2] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.String>(options, info2);
            
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Generic.List<global::System.DateTimeOffset>> info3 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Generic.List<global::System.DateTimeOffset>>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs),
                PropertyTypeInfo = jsonContext.ListDateTimeOffset,
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).DatesAvailable!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).DatesAvailable = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "DatesAvailable",
                JsonPropertyName = null
            };
        
            properties[3] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Generic.List<global::System.DateTimeOffset>>(options, info3);
            
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.HighLowTemps>> info4 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.HighLowTemps>>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs),
                PropertyTypeInfo = jsonContext.DictionaryStringHighLowTemps,
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).TemperatureRanges!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).TemperatureRanges = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "TemperatureRanges",
                JsonPropertyName = null
            };
        
            properties[4] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.HighLowTemps>>(options, info4);
            
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String[]> info5 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String[]>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs),
                PropertyTypeInfo = jsonContext.StringArray,
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).SummaryWords!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).SummaryWords = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "SummaryWords",
                JsonPropertyName = null
            };
        
            properties[5] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.String[]>(options, info5);
            
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String> info6 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String>()
            {
                IsProperty = false,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs),
                PropertyTypeInfo = jsonContext.String,
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).SummaryField!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)obj).SummaryField = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "SummaryField",
                JsonPropertyName = null
            };
        
            properties[6] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.String>(options, info6);
            
            return properties;
        }
        
        private static void WeatherForecastWithPOCOsSerializeHandler(global::System.Text.Json.Utf8JsonWriter writer, global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs? value)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }
        
            writer.WriteStartObject();
            writer.WriteString(PropName_Date, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)value).Date);
            writer.WriteNumber(PropName_TemperatureCelsius, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)value).TemperatureCelsius);
            writer.WriteString(PropName_Summary, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)value).Summary);
            writer.WritePropertyName(PropName_DatesAvailable);
            ListDateTimeOffsetSerializeHandler(writer, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)value).DatesAvailable!);
            writer.WritePropertyName(PropName_TemperatureRanges);
            DictionaryStringHighLowTempsSerializeHandler(writer, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)value).TemperatureRanges!);
            writer.WritePropertyName(PropName_SummaryWords);
            StringArraySerializeHandler(writer, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net60.WeatherForecastWithPOCOs)value).SummaryWords!);
        
            writer.WriteEndObject();
        }
    }
}
