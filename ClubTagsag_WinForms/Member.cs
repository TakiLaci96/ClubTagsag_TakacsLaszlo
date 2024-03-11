namespace ClubTagsag_WinForms
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Member
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("entry")]
        public string Entry { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("interest")]
        public Interest Interest { get; set; }


        public override string ToString()
        {
            return $"{Fullname} ";
        }

    }



    public enum Interest { Parkour, Rafting, RollerSkating, Skateboarding, Skydiving };

    public partial class Member
    {
        public static Member[] FromJson(string json) => JsonConvert.DeserializeObject<Member[]>(json, ClubTagsag_WinForms.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Member[] self) => JsonConvert.SerializeObject(self, ClubTagsag_WinForms.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                InterestConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class InterestConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Interest) || t == typeof(Interest?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Parkour":
                    return Interest.Parkour;
                case "Rafting":
                    return Interest.Rafting;
                case "Roller skating":
                    return Interest.RollerSkating;
                case "Skateboarding":
                    return Interest.Skateboarding;
                case "Skydiving":
                    return Interest.Skydiving;
            }
            throw new Exception("Cannot unmarshal type Interest");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Interest)untypedValue;
            switch (value)
            {
                case Interest.Parkour:
                    serializer.Serialize(writer, "Parkour");
                    return;
                case Interest.Rafting:
                    serializer.Serialize(writer, "Rafting");
                    return;
                case Interest.RollerSkating:
                    serializer.Serialize(writer, "Roller skating");
                    return;
                case Interest.Skateboarding:
                    serializer.Serialize(writer, "Skateboarding");
                    return;
                case Interest.Skydiving:
                    serializer.Serialize(writer, "Skydiving");
                    return;
            }
            throw new Exception("Cannot marshal type Interest");
        }

        public static readonly InterestConverter Singleton = new InterestConverter();
    }
}
