using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class LabelElement : HtmlBaseElement, IRenderElement, INestableElement
    {
        public LabelElement(string forInput)
            : base()
        {
            Attributes = new HtmlAttributes();
            Attributes.AddAttribute(new ValueAttribute("for", forInput));
        }

        public override string Tag => "label";
        public List<IRenderElement> ChildElements { get; } = new List<IRenderElement>();
        public INestableElement AddChildElements(params IRenderElement[] elements) => HtmlElementHelper.AddChildElements(this, elements);
        public List<string> ValidChildTags { get; } = new List<string>();
        public IBuildAttributesString Attributes { get; }
    }
}