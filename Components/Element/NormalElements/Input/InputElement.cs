using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public abstract class InputElement : HtmlBaseElement, IRenderElement, IAttributeElement
    {
        public InputElement()
            : base()
        {
            Attributes = new HtmlAttributes();
        }

        public override string Tag => "input";

        public IBuildAttributesString Attributes { get; }
    }
}