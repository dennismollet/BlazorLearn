using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public abstract class InputElement : VoidElement, IRenderElement, IAttributeElement
    {
        public InputElement()
            : base()
        {
            
        }

        public override string Tag => "input";

    }
}