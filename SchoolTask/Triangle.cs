namespace SchoolTask
{
	internal class Triangle
	{
		internal double _base;
		internal double _height;
		public Triangle(double theBase, double theHeight)
		{
			_base = theBase;
			_height = theHeight;
		}
		public double Area()
		{
			return _height * _base * 0.5;
		}
	}

	internal class right_angled_triangle: Triangle
	{
		public right_angled_triangle(double theBase, double theHeight) : base(theBase, theHeight) { }

		public double Hypotneus()
		{
			return Math.Sqrt(_height * _height + _base * _base);
		}

		public double Perimeter()
		{
			return Math.Sqrt(_height * _height + _base * _base) + _height + _base;
		}
	}

	internal class Isoceles_Triangle : Triangle
	{
		public double matchingSides = 0;
		public Isoceles_Triangle(double theBase, double theHeight) : base(theBase, theHeight) { }

		public double Matching_Sides()
		{
			double halfBase = _base * 0.5;
			matchingSides = Math.Sqrt(_height * _height + halfBase * halfBase);
			return matchingSides;
		}
		public double Perimeter()
		{
			return matchingSides * 2 + _base;
		}
	}
}
