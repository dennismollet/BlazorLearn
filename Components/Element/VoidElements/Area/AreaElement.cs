
using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public class AreaElement : VoidElement
    {
        public AreaElement(IAreaShape shape)
            :base()
        {
            Shape = shape;  
            Attributes.AddAttribute(Shape.BuildAreaAttribute());
        }

        public override string Tag => "area";

        public IAreaShape Shape { get; }
    }
}