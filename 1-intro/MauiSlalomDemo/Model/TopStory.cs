using Newtonsoft.Json;

namespace MauiSlalomDemo.Model;

public class TopStory
{
    [JsonProperty("section")]
    public string Section { get; set; }

    [JsonProperty("subsection")]
    public string Subsection { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("abstract")]
    public string Abstract { get; set; }

    [JsonProperty("byline")]
    public string Byline { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("image")]
    public string Image { get; set; }
}