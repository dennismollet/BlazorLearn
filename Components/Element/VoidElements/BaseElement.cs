namespace Blazor.HtmlElements
{
    public class BaseElement : VoidElement, IRenderElement, IAttributeElement
    {
        public BaseElement(string href, string target)
            : base()
        {
            Attributes.AddAttribute(new ValueAttribute("href", href));
            Attributes.AddAttribute(new ValueAttribute("target", target));
        }

        public override string Tag => "base";
    }
}