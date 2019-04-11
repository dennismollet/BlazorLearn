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
        public List<IRenderElement> ChildElements { get; } = new List<IRenderElement>();
        public INestableElement AddChildElements(params IRenderElement[] elements) => HtmlElementHelper.AddChildElements(this, elements);
        public List<string> ValidChildTags { get; } = new List<string>();
        public IBuildAttributesString Attributes { get; }

    }
}