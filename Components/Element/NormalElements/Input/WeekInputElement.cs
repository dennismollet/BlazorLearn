namespace Blazor.HtmlElements
{
    public class WeekInputElement : InputElement
    {
        public WeekInputElement()
            :base()
        {
            Attributes.AddAttribute(new WeekInputAttribute());    
        }
    }

    internal class WeekInputAttribute : ValueAttribute
    {
        public WeekInputAttribute()
            :base("type", "week")
        {

        }
    }
}