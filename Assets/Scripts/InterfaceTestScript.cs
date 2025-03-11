using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interface definition
public interface IShape
{
    float CalculateArea();
    float CalculatePerimeter();
}

// Circle class using IShape
public class Circle : IShape
{
    private float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public float CalculateArea()
    {
        return Mathf.PI * radius * radius;
    }

    public float CalculatePerimeter()
    {
        return 2 * Mathf.PI * radius;
    }
}

// Trapezium class using IShape
public class Trapezium : IShape
{
    private float base1, base2, height, side1, side2;

    public Trapezium(float base1, float base2, float height, float side1, float side2)
    {
        this.base1 = base1;
        this.base2 = base2;
        this.height = height;
        this.side1 = side1;
        this.side2 = side2;
    }

    public float CalculateArea()
    {
        return 0.5f * (base1 + base2) * height;
    }

    public float CalculatePerimeter()
    {
        return base1 + base2 + side1 + side2;
    }
}

// Nonagon class using IShape
public class Nonagon : IShape
{
    private float sideLength;
    private const int numberOfSides = 9;

    public Nonagon(float sideLength)
    {
        this.sideLength = sideLength;
    }

    public float CalculateArea()
    {
        return (9f / 4f) * (sideLength * sideLength) / Mathf.Tan(Mathf.PI / 9);
    }

    public float CalculatePerimeter()
    {
        return numberOfSides * sideLength;
    }
}

// creating objects and showing results
public class InterfaceTestScript : MonoBehaviour
{
    void Start()
    {
        // Create objects of the different shapes
        Circle circle = new Circle(10f);
        Trapezium trapezium = new Trapezium(18f, 3f, 44f, 34f, 44f);
        Nonagon nonagon = new Nonagon(18f);

        
        Debug.Log("Circle - Area: " + circle.CalculateArea() + ", Perimeter: " + circle.CalculatePerimeter());
        Debug.Log("Trapezium - Area: " + trapezium.CalculateArea() + ", Perimeter: " + trapezium.CalculatePerimeter());
        Debug.Log("Nonagon - Area: " + nonagon.CalculateArea() + ", Perimeter: " + nonagon.CalculatePerimeter());
    }
}
