namespace Blazor.HtmlElements
{
    public class BooleanAttribute : HtmlAttribute
    {
        public BooleanAttribute(string attribute)
            : base()
        {
           _Key = attribute;
        }

        protected string _Key {get;set;}
        public override string Key => _Key;

        public override string BuildAttributeString()
        {
            return $"{Key}";
        }
    }
}