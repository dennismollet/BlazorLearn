using System.Collections.Generic;
using System.Linq;

namespace Blazor.HtmlElements
{
    public class TableElement : IRenderElement, INestableElement
    {
        public TableElement()
        {
        }

        public string Tag => "table";
        protected List<IRenderElement> Elements { get; set; } = new List<IRenderElement>();

        public string RenderElement()
        {
            return $"<{Tag} ";
        }

        public void AddElement(IRenderElement element)
        {
            if (ValidTags.Contains(element.Tag) == false)
            {
                throw new System.Exception($"Cannot add tag {element.Tag} to {this.GetType()}");
            }

            Elements.Add(element);
        }
        string[] ValidTags => new string[] { "thead", "tbody", "tfoot" };
    }
}