using System.Collections.Generic;
using System.Linq;

namespace Blazor.HtmlElements
{
    public abstract class HtmlBaseElement : IRenderElement
    {
        protected HtmlBaseElement()
        {
            CssClasses = new CssClassAttribute();
            _InnerHtmlText = string.Empty;
        }

        protected string _InnerHtmlText { get; set; }
        public virtual void SetInnerHtmlText(string text)
        {
            _InnerHtmlText = text;
        }
        public string InnerHtmlText => _InnerHtmlText;

        public void AddCssClass(string name) => ((CssClassAttribute)CssClasses).AddClass(name);

        public void AddCssClasses(IEnumerable<string> names) => ((CssClassAttribute)CssClasses).AddClasses(names);
        public IBuildAttributeString CssClasses { get; }

        public virtual string RenderElement() => HtmlElementHelper.BuildElementString(this);
        public abstract string Tag { get; }
    }

    internal static class HtmlElementHelper
    {
        internal static string BuildVoidElementString(IRenderElement element)
        {
            System.Console.WriteLine(element.Tag);
            string classes = string.Empty;
            string attributes = string.Empty;

            classes = $" {((HtmlBaseElement)element).CssClasses.BuildAttributeString()}";

            if (element is IAttributeElement)
            {
                attributes += $" {BuildAttributeString((IAttributeElement)element)}";
            }

            return $"<{element.Tag}{classes}{attributes} />";
        }

        private static string BuildAttributeString(IAttributeElement element) => element.Attributes.BuildAttributesString();

        /// <summary>
        /// Render the element with its children and attributes
        /// </summary>
        /// <param name="element"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        internal static string BuildElementString(IRenderElement element)
        {
            System.Console.WriteLine(element.Tag);
            string classes = string.Empty;
            string attributes = string.Empty;
            string innerHtml = string.Empty;

            classes = $" {((HtmlBaseElement)element).CssClasses.BuildAttributeString()}";

            if (element is IAttributeElement)
            {
                attributes += $" {BuildAttributeString((IAttributeElement)element)}";
            }

            if (element is INestableElement)
            {
                innerHtml = ((INestableElement)element).RenderChildren();
            }

            return $"<{element.Tag}{classes}{attributes}>{element.InnerHtmlText}{innerHtml}</{element.Tag}>";
        }

        internal static string RenderChildren(List<IRenderElement> children)
        {
            return string.Join("", children.Select(e => e.RenderElement()));
        }
    }
}