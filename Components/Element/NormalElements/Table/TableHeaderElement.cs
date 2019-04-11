using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class TableHeaderElement : HtmlBaseElement, INestableElement, IAttributeElement
    {
        public TableHeaderElement()
            : base()
        {
            Attributes = new HtmlAttributes();
        }

        public override string Tag => "thead";
        public List<IRenderElement> ChildElements { get; } = new List<IRenderElement>();
        public INestableElement AddChildElements(params IRenderElement[] elements) => HtmlElementHelper.AddChildElements(this, elements);
        public List<string> ValidChildTags { get; } = new List<string>();
        public IBuildAttributesString Attributes { get; }
    }
}