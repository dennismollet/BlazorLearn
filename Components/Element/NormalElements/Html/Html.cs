using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class HtmlElement : HtmlBaseElement, INestableElement
    {
        public HtmlElement()
            : base()
        {

        }

        public override string Tag => "html";
        public List<IRenderElement> ChildElements { get; } = new List<IRenderElement>();
        public INestableElement AddChildElements(params IRenderElement[] elements) => HtmlElementHelper.AddChildElements(this, elements);
        public List<string> ValidChildTags { get; } = new List<string>();
    }
}