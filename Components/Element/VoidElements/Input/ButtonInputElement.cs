namespace Blazor.HtmlElements
{
    public class ButtonInputElement : InputElement
    {
        public ButtonInputElement()
            :base()
        {
            Attributes.AddAttribute(new ButtonInputAttribute());    
        }
    }

    internal class ButtonInputAttribute : ValueAttribute
    {
        public ButtonInputAttribute()
            :base("type", "button")
        {

        }
    }
}