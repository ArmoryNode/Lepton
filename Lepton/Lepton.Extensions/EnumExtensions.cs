using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lepton.Extensions
{
    public static class EnumExtensions
    {
        public static IEnumerable<T> GetEnums<T>() where T : Enum => Enum.GetValues(typeof(T)).Cast<T>();
        public static IEnumerable<string> GetStringValues<T>() where T : Enum => GetEnums<T>().Select(e => e.GetDisplayName());
    }
}
