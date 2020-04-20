﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var movies = Movies.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Movies
    {
        [JsonProperty("Nieuw")]
        public Nieuw Nieuw { get; set; }

        [JsonProperty("Actie")]
        public Actie Actie { get; set; }

        [JsonProperty("Comedy")]
        public Comedy Comedy { get; set; }

        [JsonProperty("Turks")]
        public Turks Turks { get; set; }

        [JsonProperty("Bollywood")]
        public Bollywood Bollywood { get; set; }

        [JsonProperty("Kinderfilm")]
        public Kinderfilm Kinderfilm { get; set; }

        [JsonProperty("Animatie")]
        public Animatie Animatie { get; set; }

        [JsonProperty("Familie")]
        public Familie Familie { get; set; }
    }

    public partial class Actie
    {
        [JsonProperty("A1")]
        public A1 A1 { get; set; }

        [JsonProperty("A2")]
        public A1 A2 { get; set; }

        [JsonProperty("A3")]
        public A1 A3 { get; set; }

        [JsonProperty("A4")]
        public A1 A4 { get; set; }
    }

    public partial class A1
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Genre")]
        public string Genre { get; set; }

        [JsonProperty("Age")]
        public long Age { get; set; }

        [JsonProperty("Time")]
        public string Time { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("PictureName")]
        public string PictureName { get; set; }
    }

    public partial class Animatie
    {
        [JsonProperty("Q1")]
        public A1 Q1 { get; set; }

        [JsonProperty("Q2")]
        public A1 Q2 { get; set; }

        [JsonProperty("Q3")]
        public A1 Q3 { get; set; }

        [JsonProperty("Q4")]
        public A1 Q4 { get; set; }

        [JsonProperty("Q5")]
        public A1 Q5 { get; set; }
    }

    public partial class Bollywood
    {
        [JsonProperty("B1")]
        public A1 B1 { get; set; }

        [JsonProperty("B2")]
        public A1 B2 { get; set; }

        [JsonProperty("B3")]
        public A1 B3 { get; set; }

        [JsonProperty("B4")]
        public A1 B4 { get; set; }

        [JsonProperty("B5")]
        public A1 B5 { get; set; }
    }

    public partial class Comedy
    {
        [JsonProperty("C1")]
        public A1 C1 { get; set; }

        [JsonProperty("C2")]
        public A1 C2 { get; set; }

        [JsonProperty("C3")]
        public A1 C3 { get; set; }

        [JsonProperty("C4")]
        public A1 C4 { get; set; }

        [JsonProperty("C5")]
        public A1 C5 { get; set; }
    }

    public partial class Familie
    {
        [JsonProperty("F1")]
        public A1 F1 { get; set; }

        [JsonProperty("F2")]
        public A1 F2 { get; set; }

        [JsonProperty("F3")]
        public A1 F3 { get; set; }

        [JsonProperty("F4")]
        public A1 F4 { get; set; }

        [JsonProperty("F5")]
        public A1 F5 { get; set; }
    }

    public partial class Kinderfilm
    {
        [JsonProperty("K1")]
        public A1 K1 { get; set; }

        [JsonProperty("K2")]
        public A1 K2 { get; set; }

        [JsonProperty("K3")]
        public A1 K3 { get; set; }

        [JsonProperty("K4")]
        public A1 K4 { get; set; }

        [JsonProperty("K5")]
        public A1 K5 { get; set; }
    }

    public partial class Nieuw
    {
        [JsonProperty("N1")]
        public A1 N1 { get; set; }

        [JsonProperty("N2")]
        public A1 N2 { get; set; }

        [JsonProperty("N3")]
        public A1 N3 { get; set; }

        [JsonProperty("N4")]
        public A1 N4 { get; set; }

        [JsonProperty("N5")]
        public A1 N5 { get; set; }

        [JsonProperty("N6")]
        public A1 N6 { get; set; }
    }

    public partial class Turks
    {
        [JsonProperty("T1")]
        public A1 T1 { get; set; }

        [JsonProperty("T2")]
        public A1 T2 { get; set; }

        [JsonProperty("T3")]
        public A1 T3 { get; set; }

        [JsonProperty("T4")]
        public A1 T4 { get; set; }

        [JsonProperty("T5")]
        public A1 T5 { get; set; }
    }

    public partial class Movies
    {
        public static Movies FromJson(string json) => JsonConvert.DeserializeObject<Movies>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Movies self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}