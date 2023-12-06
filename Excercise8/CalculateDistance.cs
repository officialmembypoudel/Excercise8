using System;
namespace Excercise8
{
	public class EuclideanDistance
    {
		public EuclideanDistance()
		{
		}

		public float CalculateDistance(Point2D point1, Point2D point2)
		{
			float xValue = point2.x - point1.x;

            float yValue = point2.y - point1.y;

			return (float) Math.Sqrt((xValue*xValue)+(yValue*yValue));
        }
	}
}

