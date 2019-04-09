namespace Blazor.HtmlElements
{
    public class ColorInputElement : InputElement
    {
        public ColorInputElement()
            :base()
        {
            Attributes.AddAttribute(new ColorInputAttribute());    
        }
    }

    internal class ColorInputAttribute : ValueAttribute
    {
        public ColorInputAttribute()
            :base("type", "color")
        {

        }
    }
}