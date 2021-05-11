using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
			var sphere = new List<Sphere>();
			var point = new List<Point>();

			sphere.Add(new Sphere());
			sphere[0].X0 = 2;
			sphere[0].Y0 = 7;
			sphere[0].Z0 = -2;
			sphere[0].R = 5;
			sphere[0].SphereStats();


			point.Add(new Point());
			point[0].X = -5;
			point[0].Y = -1;
			point[0].Z = 3;
			point[0].PointCoordinates();
			IsPointInsideSphere(0, 0);

            Console.WriteLine();
            Console.WriteLine("New Point: ");
			point.Add(new Point());
			point[1].X = -8;
			point[1].Y = -9;
			point[1].Z = 30;
			point[1].PointCoordinates();
			IsPointInsideSphere(1, 0);

			Console.ReadLine();




			 void IsPointInsideSphere(int p, int s)
			{

			int check = (point[p].X - sphere[s].X0)^2 + (point[p].Y - sphere[s].Y0) ^ 2 + (point[p].Z - sphere[s].Z0) ^ 2;

				if (check < (sphere[s].R ^2))
					Console.WriteLine("Point is in the sphere");

				else if (check == (sphere[s].R ^2))
					Console.WriteLine("Point lies on the sphere");

				else
					Console.WriteLine("Point is outside the sphere");
			}
						
		}

	}
}

