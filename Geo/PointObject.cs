using HotChocolate.Configuration;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors.Definitions;
using NetTopologySuite.Geometries;

namespace StarWars.Geo
{
    public class PointObject
    {
        public double lang { get; set; }
        public double lat { get; set; }

        public Point ToPoint()
        {
            return new Point(lang, lat);
        }

        public PointObject From(Point p)
        {
            return new PointObject()
            {
                lang = p.X,
                lat = p.Y
            };
        }
    }
}