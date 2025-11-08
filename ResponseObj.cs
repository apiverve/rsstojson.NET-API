using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Feed data
    /// </summary>
    public class Feed
    {
        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("pubDate")]
        public string PubDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("articles")]
        public int Articles { get; set; }

        [JsonProperty("maxReached")]
        public bool MaxReached { get; set; }

        [JsonProperty("feed")]
        public Feed[] Feed { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
