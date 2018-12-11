using System;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

public class ImageCell
{
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("cover_url")]
    public string ImageUrl { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; }
    
    public string RatingText { get => $"Rating is {_Rating}";}
    [JsonProperty("rating")]
    private double _Rating { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }
}
