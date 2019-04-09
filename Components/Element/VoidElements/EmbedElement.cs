namespace Blazor.HtmlElements
{
    public class EmbedElement : VoidElement, IRenderElement, IAttributeElement
    {
        public EmbedElement(decimal height, string src, MimeType mimeType, decimal width)
            : base()
        {
            Attributes.AddAttribute(new ValueAttribute("height", height.ToString()));
            Attributes.AddAttribute(new ValueAttribute("src", src));
            Attributes.AddAttribute(new ValueAttribute("type", mimeType.ToString()));
            Attributes.AddAttribute(new ValueAttribute("width", width.ToString()));
        }

        public override string Tag => "embed";
    }

    public enum MimeType
    {
        application,
        audio,
        font,
        example,
        image,
        message,
        model,
        multipart,
        text,
        video
    }
}