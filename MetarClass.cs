// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var topLevel = TopLevel.FromJson(jsonString);

namespace AWCAPI
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Metar
    {
        [JsonProperty("metar_id")]
        public long MetarId { get; set; }

        [JsonProperty("icaoId")]
        public string IcaoId { get; set; }

        [JsonProperty("receiptTime")]
        public DateTimeOffset ReceiptTime { get; set; }

        [JsonProperty("obsTime")]
        public long ObsTime { get; set; }

        [JsonProperty("reportTime")]
        public DateTimeOffset ReportTime { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("dewp")]
        public double Dewp { get; set; }

        [JsonProperty("wdir")]
        public long Wdir { get; set; }

        [JsonProperty("wspd")]
        public long Wspd { get; set; }

        [JsonProperty("wgst")]
        public object Wgst { get; set; }

        [JsonProperty("visib")]
        public double Visib { get; set; }

        [JsonProperty("altim")]
        public double Altim { get; set; }

        [JsonProperty("slp")]
        public object Slp { get; set; }

        [JsonProperty("qcField")]
        public long QcField { get; set; }

        [JsonProperty("wxString")]
        public string WxString { get; set; }

        [JsonProperty("presTend")]
        public object PresTend { get; set; }

        [JsonProperty("maxT")]
        public object MaxT { get; set; }

        [JsonProperty("minT")]
        public object MinT { get; set; }

        [JsonProperty("maxT24")]
        public object MaxT24 { get; set; }

        [JsonProperty("minT24")]
        public object MinT24 { get; set; }

        [JsonProperty("precip")]
        public object Precip { get; set; }

        [JsonProperty("pcp3hr")]
        public object Pcp3Hr { get; set; }

        [JsonProperty("pcp6hr")]
        public object Pcp6Hr { get; set; }

        [JsonProperty("pcp24hr")]
        public object Pcp24Hr { get; set; }

        [JsonProperty("snow")]
        public object Snow { get; set; }

        [JsonProperty("vertVis")]
        public object VertVis { get; set; }

        [JsonProperty("metarType")]
        public string MetarType { get; set; }

        [JsonProperty("rawOb")]
        public string RawOb { get; set; }

        [JsonProperty("mostRecent")]
        public long MostRecent { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("elev")]
        public long Elev { get; set; }

        [JsonProperty("prior")]
        public long Prior { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("clouds")]
        public Cloud[] Clouds { get; set; }
    }

    public partial class Cloud
    {
        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("base")]
        public long Base { get; set; }
    }
}
