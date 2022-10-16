﻿using ReferenceTypeAndValueType;
using ValueType = ReferenceTypeAndValueType.ValueType;

//Reference Type

//var p1 = new ReferenceType { X=10,Y=20};
//var p2 = p1;
//p2.X = 30;
//Console.WriteLine($"P1: {p1.X} {p1.Y}");
//Console.WriteLine($"P2: {p2.X} {p2.Y}");

//ValueTask Type

var p1 = new ValueType() { X = 10, Y = 20 };
var p2 = p1;
p2.X = 30;
Console.WriteLine($"P1: {p1.X} {p1.Y}");
Console.WriteLine($"P2: {p2.X} {p2.Y}");