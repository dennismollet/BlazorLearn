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
        public List<IRenderElement> ChildElements { get; } = new List<IRenderElement>();
        public INestableElement AddChildElements(params IRenderElement[] elements) => HtmlElementHelper.AddChildElements(this, elements);
        public List<string> ValidChildTags { get; } = new List<string>();
        public IBuildAttributesString Attributes { get; }
    }
}