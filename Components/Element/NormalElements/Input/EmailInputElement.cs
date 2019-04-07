namespace Blazor.HtmlElements
{
    public class EmailInputElement : InputElement
    {
        public EmailInputElement()
            :base()
        {
            Attributes.AddAttribute(new EmailInputAttribute());    
        }
    }

    internal class EmailInputAttribute : ValueAttribute
    {
        public EmailInputAttribute()
            :base("type", "email")
        {

        }
    }
}