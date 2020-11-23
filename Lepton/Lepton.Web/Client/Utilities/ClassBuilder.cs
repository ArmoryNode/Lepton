using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lepton.Web.Client.Utilities
{
    public class ClassBuilder
    {
        private List<string> ClassList { get; set; } = new List<string>();

        public string Build => string.Join("\u0020", ClassList.ToArray());

        public ClassBuilder()
        {
        }

        public ClassBuilder(params string[] classNameList)
        {
            ClassList.AddRange(classNameList);
        }

        public ClassBuilder Add(string className)
        {
            if (!ClassList.Any(c => c.ToLower() == className.ToLower()))
                ClassList.Add(className);
            return this;
        }

        public ClassBuilder Remove(string className)
        {
            if (ClassList.Any(c => c.ToLower() == className.ToLower()))
                ClassList.Remove(className);
            return this;
        }

        public ClassBuilder Toggle(string className)
        {
            if (ClassList.Any(c => c.ToLower() == className.ToLower()))
                ClassList.Remove(className);
            else
                ClassList.Add(className);
            return this;
        }

        public ClassBuilder Clear()
        {
            ClassList.Clear();
            return this;
        }
    }
}
