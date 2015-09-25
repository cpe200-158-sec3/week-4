# Lab402: Shape abstract class, Retangle and Triangle classes

# 1. Shape Class:
Abstract class

## Propeties:
- string Color: read-only, color of the shape, default="gold"

## Constructors:
- no default constructor
- Shape(string): takes color as a parameter

## Methods
- overriding ToString()
- getArea(): abstract method, calculate area of the shape
- getPerimeter(): abstract method, calculate perimeter of the shape

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

# 3. Triangle Class:

## Properties:
- double Width,Height: dimension of rectangle (>0, default=1.0)

## Constructors:
- Triangle(): default
- Triangle(string,double,double): takes color,width,height as parameters
- Triangle(Rectangle): copy constructor

## Methods:
- getArea(): get area of a triangle
- override ToString() method

## Questions:

1. Are there still any redundant lines of code in your project? where?
   มี คือในส่วนของPropertiesคือ Width และ Height ของclass Rectangle และ Triangle

2. Modify the project so that you can minimize or solve those redundancy.
   การย้าย Properties ทั้ง Width และ Height ไปไว้ใน class Shape

3. What happen if you uncomment line #27-28 in the Program.cs file? Why?
   โปรแกรมจะ error เพราะ Shape class เป็น Abstract class เป็นที่รวมของฟังก์ชั่นเหมาะแก่ class ที่มีการทำงานหรือใช้ฟังก์ชั่นร่วมกัน เลยไม่สามารถสร้าง object ใหม่ได้
    
4. If you uncomment line #30-24 in the Program.cs file, you will get some compile errors.
   Modify the classes and/or the program.cs without touching the "Main" method so that 
   the program will display the result as shown below:
   โปรแกรมจะทำการเพิ่มและใช้ printPerimeter ใน main class เท่านั้น
## Expected Output:

[Rectangle: width=4, height=5, area=20, color="red"]
[Triangle: base=4, height=5, area=10, color="blue"]
[Rectangle: width=1, height=1, area=1, color="gold"]
[Rectangle: width=4, height=5, area=20, color="red"]
Perimeter s1: 18
Perimeter s1: 15.4031242374328
Perimeter s1: 4
Perimeter s1: 32
Perimeter s1: 12

