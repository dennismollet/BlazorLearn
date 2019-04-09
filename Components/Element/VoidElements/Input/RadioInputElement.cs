namespace Blazor.HtmlElements
{
    public class RadioInputElement : InputElement
    {
        public RadioInputElement(string name, string value)
            :base()
        {
            Attributes.AddAttribute(new RadioInputAttribute()); 
            Attributes.AddAttribute( new ValueAttribute("name", name));
            Attributes.AddAttribute(new ValueAttribute("value", value));
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