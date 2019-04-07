namespace Blazor.HtmlElements
{
    public class CheckBoxInputElement : InputElement
    {
        public CheckBoxInputElement()
            :base()
        {
            Attributes.AddAttribute(new CheckBoxInputAttribute());    
        }
    }

    internal class CheckBoxInputAttribute : ValueAttribute
    {
        public CheckBoxInputAttribute()
            :base("type", "check")
        {

        }
    }
}