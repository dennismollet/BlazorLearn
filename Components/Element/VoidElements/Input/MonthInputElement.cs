namespace Blazor.HtmlElements
{
    public class MonthInputElement : InputElement
    {
        public MonthInputElement()
            :base()
        {
            Attributes.AddAttribute(new MonthInputAttribute());    
        }
    }

    internal class MonthInputAttribute : ValueAttribute
    {
        public MonthInputAttribute()
            :base("type", "month")
        {

        }
    }
}