using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class feed
{
    [JsonProperty("website")]
    public string website { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("pubDate")]
    public string pubDate { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

    [JsonProperty("link")]
    public string link { get; set; }

}

public class data
{
    [JsonProperty("source")]
    public string source { get; set; }

    [JsonProperty("articles")]
    public int articles { get; set; }

    [JsonProperty("maxReached")]
    public bool maxReached { get; set; }

    [JsonProperty("feed")]
    public feed[] feed { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
