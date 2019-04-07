namespace Blazor.HtmlElements
{
    public class HiddenInputElement : InputElement
    {
        public HiddenInputElement()
            :base()
        {
            Attributes.AddAttribute(new HiddenInputAttribute());    
        }
    }

    internal class HiddenInputAttribute : ValueAttribute
    {
        public HiddenInputAttribute()
            :base("type", "hidden")
        {

        }
    }
}