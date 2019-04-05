using System;
using System.Collections.Generic;
using System.Linq;

namespace Blazor.HtmlElements
{
    public class HtmlAttributes
    {
        public HtmlAttributes()
        {

        }

        protected Dictionary<string, HtmlAttribute> Attributes {get;set;} = new Dictionary<string, HtmlAttribute>();

        public void AddAttributes(HtmlAttribute attribute)
        {
            Attributes[attribute.Key] = attribute;
        }

        public string BuildAttributesString()
        {
            return string.Join(" ", Attributes.Values.Select(a => a.BuildAttribute()));
        }
    }
}