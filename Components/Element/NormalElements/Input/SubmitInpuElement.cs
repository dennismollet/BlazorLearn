namespace Blazor.HtmlElements
{
    public class SubmitInputElement : InputElement
    {
        public SubmitInputElement()
            :base()
        {
            Attributes.AddAttribute(new SubmitInputAttribute());    
        }
    }

    internal class SubmitInputAttribute : ValueAttribute
    {
        public SubmitInputAttribute()
            :base("type", "submit")
        {

        }
    }
}