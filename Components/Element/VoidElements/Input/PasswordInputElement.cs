namespace Blazor.HtmlElements
{
    public class PasswordInputElement : InputElement
    {
        public PasswordInputElement()
            :base()
        {
            Attributes.AddAttribute(new PasswordInputAttribute());    
        }
    }

    internal class PasswordInputAttribute : ValueAttribute
    {
        public PasswordInputAttribute()
            :base("type", "password")
        {

        }
    }
}