using Blazor.HtmlElements;

namespace Blazor.HtmlElements
{
/// <summary>
/// Specifies the coordinates of the top-left and bottom-right corner of the rectangle (shape="rect")
/// </summary>
    public class AreaRectangleCoordinates : IAreaCoordinates
    {
        private decimal X1 { get; set; }
        private decimal X2 { get; set; }
        private decimal Y1 { get; set; }
        private decimal Y2 { get; set; }
        public AreaRectangleCoordinates(decimal x1, decimal y1, decimal x2, decimal y2)
        {

        }

        public IBuildAttributeString BuildCoordinatesAttribute() => new ValueAttribute("coords", $"{X1},{Y1},{X2},{Y2}");
    }

    /// <summary>
    /// Specifies the coordinates of the circle center and the radius (shape="circle")
    /// </summary>
    public class AreaCircleCoordinates : IAreaCoordinates
    {
        private decimal X { get; set; }
        private decimal Y { get; set; }
        private decimal Radius { get; set; }
        public AreaCircleCoordinates(decimal x, decimal y, decimal radius)
        {

        }

        public IBuildAttributeString BuildCoordinatesAttribute() => new ValueAttribute("coords", $"{X},{Y},{Radius}");
    }


    /// <summary>
    /// Specifies the coordinates of the edges of the polygon. If the first and last coordinate pairs are not the same, the browser will add the last coordinate pair to close the polygon (shape="poly")
    /// </summary>
    public class AreaPolygonCoordinates : IAreaCoordinates
    {
        private decimal[] Coordinates { get; set; }
        public AreaPolygonCoordinates(params decimal[] coords)
        {
            Coordinates = coords;
        }

        public IBuildAttributeString BuildCoordinatesAttribute() => new ValueAttribute("coords", $"{string.Join(",", Coordinates)}");
    }
}
    