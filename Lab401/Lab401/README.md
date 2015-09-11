# Lab401: Point, Circle and Cylinder classes

# 1. Point Class:
## Propeties:
- double x, y : represent a point in 2D cartesian coordinate system 

## Constructors:
- Point(): default
- Point(Point): copy constructor
- Point(double x, double y): take x and y as parementers

## Methods
- overriding ToString()

# 2. Circle Class:
## Properties:
- Point Center: a point represent the center of a circle (use Point class)
- double Radius: radius of a circle (>=0, default=1.0)

## Constructors:
- Circle(): default
- Circle(double): takes radius as a paramenter
- Circle(double, double, double): takes x,y,radius as parameters
- Circle(Circle): copy constructor

## Methods:
- setCircle(double,double,double): take x,y,radius as parameters
- getArea(): virtual, get area of a cicle
- override ToString() method

# 3. Cylinder Class:
Inherit from the Circle class. Use a circle as a base of cylinder

## Properties:
- Height: height of the cylinder (>=0, default=1.0)

## Constructors:
- Cylinder(): default
- Cylinder(double,double): takes radius,height as a paramenters
- Cylinder(double,double,double,double): takes x,y,raduis,height as parameters
- Cylinder(Circle): takes a circle as parameter and use its properties for the Cylinder
- Cylinder(Cylinder): copy constructor

## Methods:
- getArea(): calculate outter surface area of the cylinder (should NOT have redundant code with the superclass)
- getVolume(): calculate volume of the cylinder (should NOT have redundant code with the superclass)
- override ToString() method


## Expected Output:

[Circle: center(0,0), radius=1, area=3.14159265358979]
[Circle: center(1.5,5), radius=2, area=12.5663706143592]
[Circle: center(1.5,5), radius=2, area=12.5663706143592]
[Cylinder: center(0,0), radius=1, height=1, surface=12.5663706143592, volume=3.14159265358979]
[Cylinder: center(1.5,5), radius=2, height=1, surface=37.6991118430775, volume=12.5663706143592]
[Cylinder: center(1,1), radius=3, height=4, surface=131.946891450771, volume=113.097335529233]
[Cylinder: center(1,1), radius=3, height=4, surface=131.946891450771, volume=113.097335529233]
