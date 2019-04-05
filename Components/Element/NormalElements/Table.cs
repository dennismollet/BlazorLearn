using System.Collections.Generic;
using System.Linq;

namespace Blazor.HtmlElements
{
    public class TableElement : HtmlElement, IRenderElement
    {
        public TableElement()
        {
        }

        public override string Tag => "table";
        
        internal TableHeaderElement Header {get;set;}
        internal TableBodyElement Body {get;set;}
        internal TableFooterElement Footer {get;set;}
        public string RenderElement()
        {
            return $"<{Tag}>{Header.RenderElement()}{Body.RenderElement()}{Footer.RenderElement()}</{Tag}>";
        }
        string[] ValidTags => new string[] { "thead", "tbody", "tfoot" };
    }

    internal class TableHeaderElement : HtmlElement, INestableElement
    {
        public TableHeaderElement()
            :base()
        {
        }

        public override string Tag => "thead";

        protected List<IRenderElement> Elements {get;set;} = new List<IRenderElement>();

        public void AddElement(IRenderElement element)
        {
            Elements.Add(element);
        }

        public string RenderChildren()
        {
            return HtmlElementHelper.RenderChildren(Elements);
        }

        public string RenderElement()
        {
            return HtmlElementHelper.BuildElementString(this);
           //return $"<{Tag}>{string.Join("", Elements.Select(e => e.RenderElement()))}</{Tag}>";
        }
    }

    internal class TableBodyElement : HtmlElement, INestableElement
    {
        public TableBodyElement()
            :base()
        {
        }

        public override string Tag => "tbody";

        protected List<IRenderElement> Elements {get;set;} = new List<IRenderElement>();

        public void AddElement(IRenderElement element)
        {
            Elements.Add(element);
        }
        public string RenderChildren()
        {
            return HtmlElementHelper.RenderChildren(Elements);
        }

        public string RenderElement()
        {
            return $"<{Tag}>{string.Join("", Elements.Select(e => e.RenderElement()))}</{Tag}>";
        }
    }

    internal class TableFooterElement : HtmlElement, INestableElement
    {
        public TableFooterElement()
            :base()
        {
        }

        public override string Tag => "tfoot";

        protected List<IRenderElement> Elements {get;set;} = new List<IRenderElement>();

        public void AddElement(IRenderElement element)
        {
            Elements.Add(element);
        }
        public string RenderChildren()
        {
            return HtmlElementHelper.RenderChildren(Elements);
        }

        public string RenderElement()
        {
            return $"<{Tag}>{string.Join("", Elements.Select(e => e.RenderElement()))}</{Tag}>";
        }
    }
}

