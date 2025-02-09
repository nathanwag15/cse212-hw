using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
public class FeatureCollection
{
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; } = new();
}


public class Feature
{
    [JsonPropertyName("properties")]
    public FeatureProperty Properties { get; set; }
}


public class FeatureProperty
{
    [JsonPropertyName("mag")]
    public decimal? Mag { get; set; } // Nullable decimal in case of missing data

    [JsonPropertyName("place")]
    public string Place { get; set; }
}