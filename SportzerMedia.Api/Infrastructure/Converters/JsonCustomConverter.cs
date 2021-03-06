﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SportzerMedia.Api.Infrastructure.Converters
{
    public abstract class JsonCustomConverte<T> : JsonConverter
    {
        public override bool CanWrite { get; } = false;

        public override bool CanRead { get; } = true;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        protected abstract T Create(Type objectType, JObject jObject);

        public override bool CanConvert(Type objectType)
        {
            return typeof(T) == objectType;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            var target = Create(objectType, jObject);

            return target;
        }
    }
}
