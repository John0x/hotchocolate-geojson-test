using HotChocolate.Types;
using NetTopologySuite.Geometries;

namespace StarWars
{
    [ExtendObjectType(Name = "Query")]
    public class PointQuery
    {
        public Point Hello(Point startPoint)
        {
            // Debug: the input startPoint gets converted properly
            var p = new Point(1, 1);
            
            // Debug: but it fails to convert the output
            return p;
        }
    }
}