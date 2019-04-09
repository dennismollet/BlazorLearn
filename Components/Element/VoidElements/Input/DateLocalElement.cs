namespace Blazor.HtmlElements
{
    public class DateLocalInputElement : InputElement
    {
        public DateLocalInputElement()
            :base()
        {
            Attributes.AddAttribute(new DateLocalInputAttribute());    
        }
    }

    internal class DateLocalInputAttribute : ValueAttribute
    {
        public DateLocalInputAttribute()
            :base("type", "datetime-local")
        {

        }
    }
}