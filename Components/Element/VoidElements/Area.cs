
namespace Blazor.HtmlElements
{
    // public class AreaHtmlElement : VoidHtmlElement
    // {
    //     protected override string Tag => "area";

    //     public AreaShape Shape { get; set; }
    //     public AreaShapeCoordinates Coordinates { get; set; }
    // }

    public abstract class AreaShapeCoordinates
    {
        public abstract string Value { get; }
        public abstract AreaShape CompatibleShape { get; }
    }

    /// <summary>
    /// Specifies the coordinates of the top-left and bottom-right corner of the rectangle (shape="rect")
    /// </summary>
    public class AreaShapeRectangleCoordinates : AreaShapeCoordinates
    {
        private decimal X1 { get; set; }
        private decimal X2 { get; set; }
        private decimal Y1 { get; set; }
        private decimal Y2 { get; set; }
        public AreaShapeRectangleCoordinates(decimal x1, decimal x2, decimal y1, decimal y2)
        {

        }

        public override string Value => $"{X1}{X2}{Y1}{Y2}";
        public override AreaShape CompatibleShape => AreaShape.Rectangle;
    }

    /// <summary>
    /// Specifies the coordinates of the circle center and the radius (shape="circle")
    /// </summary>
    public class AreaShapeCircleCoordinates : AreaShapeCoordinates
    {
        private decimal X { get; set; }
        private decimal Y { get; set; }
        private decimal Radius { get; set; }
        public AreaShapeCircleCoordinates(decimal x, decimal y, decimal radius)
        {

        }

        public override string Value => $"{X}{Y}{Radius}";
        public override AreaShape CompatibleShape => AreaShape.Circle;
    }


    /// <summary>
    /// Specifies the coordinates of the edges of the polygon. If the first and last coordinate pairs are not the same, the browser will add the last coordinate pair to close the polygon (shape="poly")
    /// </summary>
    public class AreaShapePolygonCoordinates : AreaShapeCoordinates
    {
        private decimal[] Coordinates { get; set; }
        public AreaShapePolygonCoordinates(params decimal[] d)
        {
            Coordinates = d;
        }

        public override string Value => $"{string.Join(",", Coordinates)}";
        public override AreaShape CompatibleShape => AreaShape.Polygon;
    }

    public enum AreaShape
    {
        Default = 0,
        Rectangle = 1,
        Circle = 2,
        Polygon = 3
    }
}