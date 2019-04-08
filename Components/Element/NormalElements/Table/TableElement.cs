using System.Collections.Generic;
using System.Linq;

namespace Blazor.HtmlElements
{
    public class TableElement : HtmlBaseElement, IRenderElement, IAttributeElement
    {
        public TableElement()
        {
            Header = new TableHeaderElement();
            Body = new TableBodyElement();
            Footer = new TableFooterElement();
            Attributes = new HtmlAttributes();
        }

        public override string Tag => "table";

        public TableHeaderElement Header { get; }
        public TableBodyElement Body { get; }
        public TableFooterElement Footer { get; }
        public override string RenderElement() => $"<{Tag}>{Header.RenderElement()}{Body.RenderElement()}{Footer.RenderElement()}</{Tag}>";
        string[] ValidTags => new string[] { "thead", "tbody", "tfoot" };
        public IBuildAttributesString Attributes { get; }
    }
}

