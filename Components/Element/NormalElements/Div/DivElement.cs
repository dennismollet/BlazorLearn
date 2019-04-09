using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class DivElement : HtmlBaseElement, INestableElement
    {
        public DivElement()
            :base()
        {
            Attributes = new HtmlAttributes();
        }
        
        public override string Tag => "div";
        protected List<IRenderElement> Elements { get; set; } = new List<IRenderElement>();

        public void AddElement(IRenderElement element) => Elements.Add(element);

        public string RenderChildren() => HtmlElementHelper.RenderChildren(Elements);
        public IBuildAttributesString Attributes { get; }

    }
}