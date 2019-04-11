namespace Blazor.HtmlElements
{
    public abstract class VoidElement : HtmlBaseElement, IRenderElement, IAttributeElement
    {
        public VoidElement()
        {
            Attributes = new HtmlAttributes();
        }

        public IBuildAttributesString Attributes { get; }

        public override IRenderElement SetInnerHtmlText(string text) { return this; } //not valid on void element
        public override string RenderElement() => HtmlElementHelper.BuildVoidElementString(this);
    }
}