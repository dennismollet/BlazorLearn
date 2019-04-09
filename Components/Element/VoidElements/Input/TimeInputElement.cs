namespace Blazor.HtmlElements
{
    public class TimeInputElement : InputElement
    {
        public TimeInputElement()
            :base()
        {
            Attributes.AddAttribute(new TimeInputAttribute());    
        }
    }

    internal class TimeInputAttribute : ValueAttribute
    {
        public TimeInputAttribute()
            :base("type", "time")
        {

        }
    }
}