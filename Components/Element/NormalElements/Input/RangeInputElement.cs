namespace Blazor.HtmlElements
{
    public class RangeInputElement : InputElement
    {
        public RangeInputElement()
            :base()
        {
            Attributes.AddAttribute(new RangeInputAttribute());    
        }
    }

    internal class RangeInputAttribute : ValueAttribute
    {
        public RangeInputAttribute()
            :base("type", "range")
        {

        }
    }
}