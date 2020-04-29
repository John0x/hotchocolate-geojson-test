using HotChocolate.Types;
using NetTopologySuite.Geometries;
using StarWars.Geo;

namespace StarWars
{
    [ExtendObjectType(Name = "Query")]
    public class PointQuery
    {
        public string Hello(PointObject startPoint)
        {
            // convert to real Point
            var p = new Point(1, 2);

            // convert to PointOutput
            return "da";
        }
    }
}