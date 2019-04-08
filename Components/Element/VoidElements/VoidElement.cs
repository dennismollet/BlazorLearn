namespace Blazor.HtmlElements
{
    public abstract class VoidElement : HtmlBaseElement, IRenderElement, IAttributeElement
    {
        public VoidElement()
        {
            Attributes = new HtmlAttributes();
        }

        public IBuildAttributesString Attributes { get; }
    }
}