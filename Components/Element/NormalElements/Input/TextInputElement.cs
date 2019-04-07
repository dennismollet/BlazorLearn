namespace Blazor.HtmlElements
{
    public class TextInputElement : InputElement
    {
        public TextInputElement()
            :base()
        {
            Attributes.AddAttribute(new TextInputAttribute());    
        }
    }

    internal class TextInputAttribute : ValueAttribute
    {
        public TextInputAttribute()
            :base("type", "text")
        {

        }
    }
}