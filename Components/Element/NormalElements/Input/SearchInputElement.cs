namespace Blazor.HtmlElements
{
    public class SearchInputElement : InputElement
    {
        public SearchInputElement()
            :base()
        {
            Attributes.AddAttribute(new SearchInputAttribute());    
        }
    }

    internal class SearchInputAttribute : ValueAttribute
    {
        public SearchInputAttribute()
            :base("type", "search")
        {

        }
    }
}