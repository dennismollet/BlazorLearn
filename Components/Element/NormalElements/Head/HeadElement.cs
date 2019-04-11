using System;
using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class HeadElement : HtmlBaseElement, INestableElement
    {
        public HeadElement()
            : base()
        {
            
        }

        public override string Tag => "head";
        public List<IRenderElement> ChildElements { get; } = new List<IRenderElement>();
        public INestableElement AddChildElements(params IRenderElement[] elements) => HtmlElementHelper.AddChildElements(this, elements);
        public List<string> ValidChildTags { get; } = new List<string> { "title", "style", "base", "link", "meta", "script", "noscript" };
    }
}