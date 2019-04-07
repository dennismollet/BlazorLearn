namespace Blazor.HtmlElements
{
    public class ImageInputElement : InputElement
    {
        public ImageInputElement()
            :base()
        {
            Attributes.AddAttribute(new ImageInputAttribute());    
        }
    }

    internal class ImageInputAttribute : ValueAttribute
    {
        public ImageInputAttribute()
            :base("type", "image")
        {

        }
    }
}