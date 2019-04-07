using System;
using System.Collections.Generic;
using System.Linq;

namespace Blazor.HtmlElements
{
    public class HtmlAttributes : IBuildAttributesString
    {
        public HtmlAttributes()
        {

        }

        protected Dictionary<string, IBuildAttributeString> Attributes {get;set;} = new Dictionary<string, IBuildAttributeString>();

        public void AddAttribute(IBuildAttributeString attribute) => Attributes[attribute.Key] = attribute;

        public void AddAttributes(IEnumerable<IBuildAttributeString> attributes)
        {
            foreach(var attribute in attributes)
            {
                Attributes[attribute.Key] = attribute;
            }
        }

        public string BuildAttributesString() => string.Join(" ", Attributes.Values.Select(a => a.BuildAttributeString()));
    }
}