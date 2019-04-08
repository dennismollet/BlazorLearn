using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class Html : HtmlElement, INestableElement
    {
        public Html()
            : base()
        {

        }

        public override string Tag => "html";

        protected List<IRenderElement> Elements { get; set; } = new List<IRenderElement>();

        public void AddElement(IRenderElement element) => Elements.Add(element);

        public string RenderChildren() => HtmlElementHelper.RenderChildren(Elements);

    }
}