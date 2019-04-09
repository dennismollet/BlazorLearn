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
        protected List<IRenderElement> Elements { get; set; } = new List<IRenderElement>();

        public void AddElement(IRenderElement element) => Elements.Add(element);

        public string RenderChildren() => HtmlElementHelper.RenderChildren(Elements);
        public IBuildAttributesString Attributes { get; }
    }
}