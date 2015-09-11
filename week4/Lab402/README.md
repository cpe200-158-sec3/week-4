# Lab402: Shape abstract class, Retangle and Triangle classes

# 1. Shape Class:
Abstract class

## Propeties:
- private string color: color of the shape

## Constructors:
- Shape(string): takes color as a parameter

## Methods
- overriding ToString()
- getArea(): abstract method, calculate area of the shape

# 2. Rectangle Class:

## Properties:
- double Width,Height: dimension of rectangle (>0, default=1.0)

## Constructors:
- Rectangle(): default
- Rectangle(string,double,double): takes color,width,height as parameters
- Rectangle(Rectangle): copy constructor

## Methods:
- getArea(): get area of a rectangle
- override ToString() method

# 3. Cylinder Class:

## Properties:
- double Width,Height: dimension of rectangle (>0, default=1.0)

## Constructors:
- Triangle(): default
- Triangle(string,double,double): takes color,width,height as parameters
- Triangle(Rectangle): copy constructor

## Methods:
- getArea(): get area of a triangle
- override ToString() method

## Expected Output:


## Questions:

1. Can the program compile correctly?
2. How to solve the problem mentioned above?
3. Are there still any redundant lines of code in your project? where?
4. Modify the project so that you can minimize or solve those redundancy.


