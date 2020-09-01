using System;

namespace SSELib
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class InDevelopmentAttribute : Attribute
    {
        public string Info { get; set; }
    }
}
