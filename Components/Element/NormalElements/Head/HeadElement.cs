using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class HeadElement : HtmlElement, INestableElement
    {
        public HeadElement()
            : base()
        {

        }

        public override string Tag => "head";

        protected List<IRenderElement> Elements { get; set; } = new List<IRenderElement>();

        public void AddElement(IRenderElement element)
        {
            if (ValidChildTags.Contains(element.Tag))
            {
                Elements.Add(element);
            }
        }

        public string RenderChildren() => HtmlElementHelper.RenderChildren(Elements);

        private List<string> ValidChildTags => new List<string> { "title", "style", "base", "link", "meta", "script", "noscript" };
    }
}