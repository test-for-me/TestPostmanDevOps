using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace APIParser
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PostmanModel
    {
        [JsonProperty("collection")]
        public Collection Collection { get; set; }

        [JsonProperty("environment")]
        public Environment Environment { get; set; }

        [JsonProperty("globals")]
        public Environment Globals { get; set; }

        [JsonProperty("run")]
        public Run Run { get; set; }
    }

    public partial class Collection
    {
        [JsonProperty("_")]
        public Empty Empty { get; set; }

        [JsonProperty("item")]
        public Item[] Item { get; set; }

        [JsonProperty("event")]
        public object[] Event { get; set; }

        [JsonProperty("variable")]
        public object[] Variable { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }
    }

    public partial class Empty
    {
        [JsonProperty("postman_id")]
        public Guid PostmanId { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("_postman_id")]
        public Guid PostmanId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("schema")]
        public Uri Schema { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("response")]
        public object[] Response { get; set; }

        [JsonProperty("event")]
        public object[] Event { get; set; }
    }

    public partial class Request
    {
        [JsonProperty("url")]
        public Url Url { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("body")]
        public Body Body { get; set; }

        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Header[] Header { get; set; }
    }

    public partial class Body
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("raw")]
        public string Raw { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class Url
    {
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("path")]
        public string[] Path { get; set; }

        [JsonProperty("host")]
        public string[] Host { get; set; }

        [JsonProperty("query")]
        public Header[] Query { get; set; }

        [JsonProperty("variable")]
        public object[] Variable { get; set; }
    }

    public partial class Environment
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("values")]
        public object[] Values { get; set; }
    }

    public partial class Run
    {
        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("timings")]
        public Timings Timings { get; set; }

        [JsonProperty("executions")]
        public Execution[] Executions { get; set; }

        [JsonProperty("transfers")]
        public Transfers Transfers { get; set; }

        [JsonProperty("failures")]
        public object[] Failures { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }

    public partial class Execution
    {
        [JsonProperty("cursor")]
        public Cursor Cursor { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }
    }

    public partial class Cursor
    {
        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("iteration")]
        public long Iteration { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }

        [JsonProperty("cycles")]
        public long Cycles { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("eof")]
        public bool Eof { get; set; }

        [JsonProperty("bof")]
        public bool Bof { get; set; }

        [JsonProperty("cr")]
        public bool Cr { get; set; }

        [JsonProperty("ref")]
        public Guid Ref { get; set; }

        [JsonProperty("httpRequestId")]
        public Guid HttpRequestId { get; set; }
    }

    public partial class Response
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("header")]
        public Header[] Header { get; set; }

        [JsonProperty("stream")]
        public Stream Stream { get; set; }

        [JsonProperty("cookie")]
        public object[] Cookie { get; set; }

        [JsonProperty("responseTime")]
        public long ResponseTime { get; set; }

        [JsonProperty("responseSize")]
        public long ResponseSize { get; set; }
    }

    public partial class Stream
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("data")]
        public long[] Data { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("iterations")]
        public Assertions Iterations { get; set; }

        [JsonProperty("items")]
        public Assertions Items { get; set; }

        [JsonProperty("scripts")]
        public Assertions Scripts { get; set; }

        [JsonProperty("prerequests")]
        public Assertions Prerequests { get; set; }

        [JsonProperty("requests")]
        public Assertions Requests { get; set; }

        [JsonProperty("tests")]
        public Assertions Tests { get; set; }

        [JsonProperty("assertions")]
        public Assertions Assertions { get; set; }

        [JsonProperty("testScripts")]
        public Assertions TestScripts { get; set; }

        [JsonProperty("prerequestScripts")]
        public Assertions PrerequestScripts { get; set; }
    }

    public partial class Assertions
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("pending")]
        public long Pending { get; set; }

        [JsonProperty("failed")]
        public long Failed { get; set; }
    }

    public partial class Timings
    {
        [JsonProperty("responseAverage")]
        public long ResponseAverage { get; set; }

        [JsonProperty("started")]
        public long Started { get; set; }

        [JsonProperty("completed")]
        public long Completed { get; set; }
    }

    public partial class Transfers
    {
        [JsonProperty("responseTotal")]
        public long ResponseTotal { get; set; }
    }
}
