using System;
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
        public virtual IRenderElement SetInnerHtmlText(string text)
        {
            _InnerHtmlText = text;
            return this;
        }
        public string InnerHtmlText => _InnerHtmlText;

        public virtual IRenderElement AddCssClasses(params string[] names)
        {
            CssClasses.AddAttributeValues(names);
            return this;
        }

        public IMultipleValueAttribute CssClasses { get; }

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
        internal static string BuildElementString(HtmlBaseElement element)
        {
            System.Console.WriteLine(element.Tag);
            string classes = string.Empty;
            string attributes = string.Empty;
            string innerHtml = string.Empty;

            classes = $" {element.CssClasses.BuildAttributeString()}";

            if (element is IAttributeElement)
            {
                attributes += $" {BuildAttributeString((IAttributeElement)element)}";
            }

            if (element is INestableElement)
            {
                innerHtml = RenderChildren(((INestableElement)element).ChildElements);
            }

            return $"<{element.Tag}{classes}{attributes}>{element.InnerHtmlText}{innerHtml}</{element.Tag}>";
        }

        internal static string RenderChildren(List<IRenderElement> children)
        {
            return string.Join("", children.Select(e => e.RenderElement()));
        }

        internal static INestableElement AddChildElements(INestableElement element, params IRenderElement[]  childElementsToAdd)
        {
            foreach(var childElementToAdd in childElementsToAdd)
            {
                if (element.ValidChildTags?.Count == 0 || element.ValidChildTags.Contains(element.Tag))
                {
                    element.ChildElements.Add(childElementToAdd);
                }
                else
                {
                    Console.WriteLine($"Element <{childElementToAdd.Tag}> is not valid to be added as a child of <{element.Tag}>");
                }
            }

            return element;
        }
    }
}