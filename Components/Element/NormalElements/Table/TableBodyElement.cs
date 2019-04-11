using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class TableBodyElement : HtmlBaseElement, INestableElement, IAttributeElement
    {
        public TableBodyElement()
            : base()
        {
            Attributes = new HtmlAttributes();
        }

        public override string Tag => "tbody";
        public List<IRenderElement> ChildElements { get; } = new List<IRenderElement>();
        public INestableElement AddChildElements(params IRenderElement[] elements) => HtmlElementHelper.AddChildElements(this, elements);
        public List<string> ValidChildTags { get; } = new List<string>();
        public IBuildAttributesString Attributes { get; }
    }
}