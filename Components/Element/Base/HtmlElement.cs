using System.Collections.Generic;
using System.Linq;

namespace Blazor.HtmlElements
{
    public abstract class HtmlElement : IHtmlElement
    {
        protected HtmlElement() { }
        public abstract string Tag { get; }
    }

    public static class HtmlElementHelper
    {
        public static string BuildVoidElementString(string tag)
        {
            return $"<{tag} />";
        }

        public static string BuildElementString(IRenderElement element)
        {
            return $"<{element.Tag}></{element.Tag}>";
        }

        public static string BuildElementString(IRenderElement element, HtmlAttributes attributes)
        {
            return $"<{element.Tag} {attributes.BuildAttributesString()}></{element.Tag}>";
        }

        public static string BuildElementString(INestableElement element, HtmlAttributes attributes)
        {
            return $"<{element.Tag} {attributes.BuildAttributesString()}>{element.RenderChildren()}</{element.Tag}>";
        }

        public static string RenderChildren(List<IRenderElement> children)
        {
            return string.Join("", children.Select(e => e.RenderElement()));
        }
    }
}