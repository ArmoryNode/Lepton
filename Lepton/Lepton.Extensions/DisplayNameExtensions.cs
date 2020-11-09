using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Lepton.Extensions
{
    public static class DisplayNameExtensions
    {
        public static string GetDisplayName(this object obj) =>
            obj.GetType().GetCustomAttribute<DisplayAttribute>()?.Name ?? obj.ToString();
    }
}
