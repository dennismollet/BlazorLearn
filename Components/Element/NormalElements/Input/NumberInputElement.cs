namespace Blazor.HtmlElements
{
    public class NumberInputElement : InputElement
    {
        public NumberInputElement()
            :base()
        {
            Attributes.AddAttribute(new NumberInputAttribute());    
        }
    }

    internal class NumberInputAttribute : ValueAttribute
    {
        public NumberInputAttribute()
            :base("type", "number")
        {

        }
    }
}