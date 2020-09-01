using System;

namespace SSELib
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class CustomSerializationAttribute : Attribute
    {
        public string SerializerMethod { get; set; }

        public string DeserializerMethod { get; set; }
    }
}
