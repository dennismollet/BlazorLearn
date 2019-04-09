namespace Blazor.HtmlElements
{
    public class TelephoneInputElement : InputElement
    {
        public TelephoneInputElement()
            :base()
        {
            Attributes.AddAttribute(new TelephoneInputAttribute());    
        }
    }

    internal class TelephoneInputAttribute : ValueAttribute
    {
        public TelephoneInputAttribute()
            :base("type", "telephone")
        {

        }
    }
}