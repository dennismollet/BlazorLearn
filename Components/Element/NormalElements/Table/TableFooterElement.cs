using System.Collections.Generic;

namespace  Blazor.HtmlElements
{
    public class TableFooterElement : HtmlElement, INestableElement, IAttributeElement
    {
        public TableFooterElement()
            :base()
        {
            Attributes = new HtmlAttributes();
        }

        public override string Tag => "tfoot";

        protected List<IRenderElement> Elements {get;set;} = new List<IRenderElement>();

        public void AddElement(IRenderElement element) => Elements.Add(element);
        
        public string RenderChildren() => HtmlElementHelper.RenderChildren(Elements);
        public IBuildAttributesString Attributes { get; }
    }
}