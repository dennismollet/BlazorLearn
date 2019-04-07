using System.Collections.Generic;
using System.Linq;

namespace Blazor.HtmlElements
{
    public abstract class HtmlElement : IRenderElement
    {
        protected HtmlElement() 
        {
            CssClasses = new CssClassAttribute();
        }

        public void AddCssClass(string name)
        {
            ((CssClassAttribute)CssClasses).AddClass(name);
        }

        public void AddCssClasses(IEnumerable<string> names)
        {
            ((CssClassAttribute)CssClasses).AddClasses(names);
        }
        public IBuildAttributeString CssClasses {get;}

        public virtual string RenderElement() => HtmlElementHelper.BuildElementString(this);
        public abstract string Tag { get; }
    }

    internal static class HtmlElementHelper
    {
        internal static string BuildVoidElementString(string tag)
        {
            return $"<{tag} />";
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
            string classes = string.Empty;            
            string attributes = string.Empty;
            string innerHtml = string.Empty;

            classes = $" {((HtmlElement)element).CssClasses.BuildAttributeString()}";
            
            if(element is IAttributeElement)
            {
                attributes += $" {BuildAttributeString((IAttributeElement)element)}";                
            }

            if(element is INestableElement)
            {
                innerHtml = ((INestableElement)element).RenderChildren();
            }

            return $"<{element.Tag}{classes}{attributes}>{innerHtml}</{element.Tag}>";
        }

        internal static string RenderChildren(List<IRenderElement> children)
        {
            return string.Join("", children.Select(e => e.RenderElement()));
        }
    }
}