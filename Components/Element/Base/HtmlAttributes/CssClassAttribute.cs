using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class CssClassAttribute : HtmlAttribute
    {
        public CssClassAttribute(List<string> values)
            : base()
        {
            Values = values;
        }

        public override string Key => "class";

        protected List<string> Values {get;set;} = new List<string>();

        public override string BuildAttribute()
        {
            return $"class='{string.Join(" ", Values)}'";
        }
    }
}