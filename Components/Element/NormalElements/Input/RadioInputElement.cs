namespace Blazor.HtmlElements
{
    public class RadioInputElement : InputElement
    {
        public RadioInputElement()
            :base()
        {
            Attributes.AddAttribute(new RadioInputAttribute());    
        }
    }

    internal class RadioInputAttribute : ValueAttribute
    {
        public RadioInputAttribute()
            :base("type", "radio")
        {

        }
    }
}