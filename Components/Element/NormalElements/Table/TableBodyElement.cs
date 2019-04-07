using System.Collections.Generic;

namespace  Blazor.HtmlElements
{
    public class TableBodyElement : HtmlElement, INestableElement, IAttributeElement
    {
        public TableBodyElement()
            :base()
        {
            Attributes = new HtmlAttributes();
        }

        public override string Tag => "tbody";

        protected List<IRenderElement> Elements {get;set;} = new List<IRenderElement>();

        public void AddElement(IRenderElement element) => Elements.Add(element);

        public string RenderChildren() => HtmlElementHelper.RenderChildren(Elements);
        public IBuildAttributesString Attributes { get; }
    }
}