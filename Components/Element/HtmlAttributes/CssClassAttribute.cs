using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class CssClassAttribute : HtmlAttribute
    {
        internal CssClassAttribute()
        {
            
        }

        public override string Key => "class";

        protected HashSet<string> Values {get;set;} = new HashSet<string>();

        internal void AddClass(string name) => Values.Add(name);

        internal void AddClasses(IEnumerable<string> names) => Values.UnionWith(names);

        public override string BuildAttributeString()
        {
            if(Values.Count > 0)
            {
                return $"class=\"{string.Join(" ", Values)}\"";
            }
            
            return string.Empty;
        }
    }
}