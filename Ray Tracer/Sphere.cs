using System;

namespace rt
{
    public class Sphere : Geometry
    {
        private Vector Center { get; set; }
        private double Radius { get; set; }

        public Sphere(Vector center, double radius, Material material, Color color) : base(material, color)
        {
            Center = center;
            Radius = radius;
        }

        public override Intersection GetIntersection(Line line, double minDist, double maxDist)
        {
            // ADD CODE HERE: Calculate the intersection between the given line and this sphere
            double A = (line.Dx * line.Dx);
            double B = 2 * ((line.Dx) * (line.X0 - Center));
            double C = (line.X0 - Center) * (line.X0 - Center) - Radius * Radius;

            double delta = B * B - 4 * A * C;

            if (delta == 0 )
            {
                double t = (-1) * B / (2 * A);
                
                Intersection intersection = new Intersection(true, false, this, line, t);

                if (minDist <= t && t <= maxDist)
                    intersection.Visible = true;

                return intersection;
            }
            else if (delta > 0)
            {
                double sqrt_delta = Math.Sqrt(delta);
                double t1 = ((-1) * B - sqrt_delta) / (2 * A);
                double t2 = ((-1) * B + sqrt_delta) / (2 * A);

                if (minDist <= t1 && t1 <= maxDist)
                {
                    return new Intersection(true, true, this, line, t1);
                }
                else if (minDist >= t2 && t2 >= maxDist)
                {
                    return new Intersection(true, true, this, line, t2);
                }
                else
                {
                    return new Intersection(true, false, this, line, t2);
                }
            }
            return new Intersection();
        }

        public override Vector Normal(Vector v)
        {
            var n = v - Center;
            n.Normalize();
            return n;
        }
    }
}