using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PropertiesReflection
{
    public static class PropertiesExtension
    {
        public static List<PropertyInfo> GetProperties<T>(this T obj)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();

            return properties.ToList();
        }
    }
}
