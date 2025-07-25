using System;

#region First Project
class Point3D : IComparable<Point3D>, ICloneable
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point3D() : this(0, 0, 0) { }

    public Point3D(int x, int y) : this(x, y, 0) { }


    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }


    public override string ToString()
    {
        return $"Point Coordinates: ({X}, {Y}, {Z})";
    }


    public override bool Equals(object obj)
    {
        if (obj is Point3D p)
            return X == p.X && Y == p.Y && Z == p.Z;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    // Overloading == and !=
    public static bool operator ==(Point3D a, Point3D b)
    {
        if (ReferenceEquals(a, null)) return ReferenceEquals(b, null);
        return a.Equals(b);
    }

    public static bool operator !=(Point3D a, Point3D b)
    {
        return !(a == b);
    }

    // Implement IComparable - Sort by X then Y
    public int CompareTo(Point3D other)
    {
        if (X != other.X)
            return X.CompareTo(other.X);
        return Y.CompareTo(other.Y);
    }

    // Implement ICloneable
    public object Clone()
    {
        return new Point3D(this.X, this.Y, this.Z);
    }
}

class Program
{
    static int ReadInt(string message)
    {
        int value;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Try again: ");
        }
        return value;
    }

    static void Main()
    {

        Point3D P = new Point3D(10, 10, 10);
        Console.WriteLine(P.ToString());


        Console.WriteLine("Enter coordinates for P1:");
        int x1 = ReadInt("X: ");
        int y1 = ReadInt("Y: ");
        int z1 = ReadInt("Z: ");
        Point3D P1 = new Point3D(x1, y1, z1);

        Console.WriteLine("Enter coordinates for P2:");
        int x2 = ReadInt("X: ");
        int y2 = ReadInt("Y: ");
        int z2 = ReadInt("Z: ");
        Point3D P2 = new Point3D(x2, y2, z2);


        Console.WriteLine($"P1 == P2? {(P1 == P2 ? "Yes" : "No")}");


        Point3D[] points = {
            new Point3D(5, 2, 1),
            new Point3D(3, 9, 0),
            new Point3D(5, 1, 4),
            new Point3D(3, 5, 7)
        };

        Array.Sort(points);

        Console.WriteLine("\nSorted Points (by X, then Y):");
        foreach (var pt in points)
            Console.WriteLine(pt);

        Point3D cloned = (Point3D)P1.Clone();
        Console.WriteLine($"\nCloned P1: {cloned}");
    }
}
#endregion



#region Second Project

class Maths
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Divide(int a, int b)
    {
        return (double)a / b;
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first Number");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Second Number");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Add: " + Maths.Add(a, b));
        Console.WriteLine("Subtract: " + Maths.Subtract(a, b));
        Console.WriteLine("Multiply: " + Maths.Multiply(a, b));
        Console.WriteLine("Divide: " + Maths.Divide(a, b));
    }
}

#endregion
