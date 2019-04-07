namespace Blazor.HtmlElements
{
    public class ResetInputElement : InputElement
    {
        public ResetInputElement()
            :base()
        {
            Attributes.AddAttribute(new ResetInputAttribute());    
        }
    }

    internal class ResetInputAttribute : ValueAttribute
    {
        public ResetInputAttribute()
            :base("type", "reset")
        {

        }
    }
}