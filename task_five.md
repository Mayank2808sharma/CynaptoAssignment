An abstract class is a class that cannot be instantiated but can only be inherited by other classes. It is a blueprint for other classes to follow and provides common methods and properties to those classes.

It is used when there is a need to have a common structure or behavior for a group of related classes. By making one or more classes abstract, we can define a set of methods that must be implemented by any derived class. It promotes code reuse, abstraction, and encapsulation.

For example, let's say we have a set of shapes like circle, rectangle, and triangle.
We can create an abstract class called Shape that provides common properties and methods like calculating the area and perimeter of the shape. Then we can have classes like "Circle," "Rectangle," and "Triangle" inherit from the "Shape" class and implement their own area and perimeter calculation methods.

```java
abstract class Shape {
   private String color;

   public Shape(String c) {
      color = c;
   }

   public String getColor() {
      return color;
   }

   public abstract double getArea();
   public abstract double getPerimeter();
}

class Circle extends Shape {
   private double radius;

   public Circle(String c, double r) {
      super(c);
      radius = r;
   }

   public double getArea() {
      return Math.PI * radius * radius;
   }

   public double getPerimeter() {
      return 2 * Math.PI * radius;
   }
}
```

This is an example of a derived class "Circle" that implements the "getArea" and "getPerimeter" methods.
