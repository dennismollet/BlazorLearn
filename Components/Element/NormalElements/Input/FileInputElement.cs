namespace Blazor.HtmlElements
{
    public class FileInputElement : InputElement
    {
        public FileInputElement()
            :base()
        {
            Attributes.AddAttribute(new FileInputAttribute());    
        }
    }

    internal class FileInputAttribute : ValueAttribute
    {
        public FileInputAttribute()
            :base("type", "file")
        {

        }
    }
}