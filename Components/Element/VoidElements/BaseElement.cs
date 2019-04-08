namespace Blazor.HtmlElements
{
    public class BaseElement : HtmlBaseElement, IRenderElement, IAttributeElement
    {
        public BaseElement(string href, string target)
            : base()
        {
            Attributes = new HtmlAttributes();
            Attributes.AddAttribute(new ValueAttribute("href", href));
            Attributes.AddAttribute(new ValueAttribute("target", target));
        }

        public IBuildAttributesString Attributes { get; }

        public override string Tag => "base";
    }
}