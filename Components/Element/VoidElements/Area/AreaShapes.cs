using Blazor.HtmlElements;

namespace Blazor.HtmlElements
{
    public abstract class Area
    {
        protected Area(IAreaCoordinates coordinates)
        {
            Coordinates = coordinates;
        }

        public IAreaCoordinates Coordinates { get; }
    }

    public class AreaRectangle : Area, IAreaShape
    {
        public AreaRectangle(AreaRectangleCoordinates rectangleCoordinates)
            :base (rectangleCoordinates)
        {
            
        }

        public IBuildAttributeString BuildAreaAttribute() => new ValueAttribute("shape", "rect");
    }
    public class AreaCircle : Area, IAreaShape
    {
        public AreaCircle(AreaCircleCoordinates rectangleCoordinates)
            :base (rectangleCoordinates)
        {
            
        }

        public IBuildAttributeString BuildAreaAttribute() => new ValueAttribute("shape", "circle");
    }
    public class AreaPolygon : Area, IAreaShape
    {
        public AreaPolygon(AreaPolygonCoordinates rectangleCoordinates)
            :base (rectangleCoordinates)
        {
            
        }

        public IBuildAttributeString BuildAreaAttribute() => new ValueAttribute("shape", "poly");
    }
}