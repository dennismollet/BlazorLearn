using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class ValueAttribute : HtmlAttribute
    {
        public ValueAttribute(string attribute, string value)
            : base()
        {
           _Key = attribute;
           _Value = value;
        }

        protected string _Key {get;set;}
        public override string Key => _Key;

        protected string _Value {get;set;}
        public string Value => _Value;

        public override string BuildAttribute()
        {
            return $"{Key}='{Value}'";
        }
    }
}