using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class SpanElement : HtmlBaseElement, IRenderElement, INestableElement
    {
        public SpanElement()
            : base()
        {

            Attributes = new HtmlAttributes();
        }

        public override string Tag => "span";
        protected List<IRenderElement> Elements { get; set; } = new List<IRenderElement>();

        public void AddElement(IRenderElement element) => Elements.Add(element);

        public string RenderChildren() => HtmlElementHelper.RenderChildren(Elements);
        public IBuildAttributesString Attributes { get; }
    }
}