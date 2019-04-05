using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class ValuesAttribute : HtmlAttribute
    {
        public ValuesAttribute(string attribute, List<string> values)
            : base()
        {
           _Key = attribute;
           _Values = values;
        }

        protected string _Key {get;set;}
        public override string Key => _Key;

        protected List<string> _Values {get;set;}
        public List<string> Values => _Values;

        protected virtual string Separator => " ";
        public override string BuildAttribute()
        {
            return $"{Key}='{string.Join(Separator, Values)}'";
        }
    }
}