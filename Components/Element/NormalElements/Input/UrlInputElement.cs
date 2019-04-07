namespace Blazor.HtmlElements
{
    public class UrlInputElement : InputElement
    {
        public UrlInputElement()
            :base()
        {
            Attributes.AddAttribute(new UrlInputAttribute());    
        }
    }

    internal class UrlInputAttribute : ValueAttribute
    {
        public UrlInputAttribute()
            :base("type", "url")
        {

        }
    }
}