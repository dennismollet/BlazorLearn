namespace Blazor.HtmlElements
{
    public class DateInputElement : InputElement
    {
        public DateInputElement()
            :base()
        {
            Attributes.AddAttribute(new DateInputAttribute());    
        }
    }

    internal class DateInputAttribute : ValueAttribute
    {
        public DateInputAttribute()
            :base("type", "date")
        {

        }
    }
}