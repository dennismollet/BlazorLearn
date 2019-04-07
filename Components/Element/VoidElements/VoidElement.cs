namespace Blazor.HtmlElements
{
    public abstract class VoidElement : HtmlElement, IRenderElement, IAttributeElement
    {
        public VoidElement()
        {
            Attributes = new HtmlAttributes();
        }

        public IBuildAttributesString Attributes { get; }
    }
}