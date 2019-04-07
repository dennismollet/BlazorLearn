namespace Blazor.HtmlElements
{
    public class EmbedElement : HtmlElement, IRenderElement, IAttributeElement
    {
        public EmbedElement(decimal height, string src, MimeType mimeType, decimal width)
            :base()
        {
            Attributes = new HtmlAttributes();
            Attributes.AddAttribute(new ValueAttribute("height", height.ToString()));
            Attributes.AddAttribute(new ValueAttribute("src", src));
            Attributes.AddAttribute(new ValueAttribute("type", mimeType.ToString()));
            Attributes.AddAttribute(new ValueAttribute("width", width.ToString()));
        }

        public IBuildAttributesString Attributes { get; }

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