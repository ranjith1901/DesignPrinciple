# Design Principles in C#

This repository contains explanations of various design principles in C#. Each principle is described to help you understand and apply them in your projects.

## Table of Contents
1. Single Responsibility Principle (SRP)
2. Open/Closed Principle (OCP)
3. Liskov Substitution Principle (LSP)
4. Interface Segregation Principle (ISP)
5. Dependency Inversion Principle (DIP)

## Single Responsibility Principle (SRP)
A class should have only one reason to change, meaning it should only have one job or responsibility. This principle helps in reducing the complexity of a class and makes it easier to understand and maintain.

## Open/Closed Principle (OCP)
Software entities should be open for extension but closed for modification. This means you should be able to add new functionality without changing existing code, which helps in preventing bugs and makes the system more maintainable.

## Liskov Substitution Principle (LSP)
Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. This principle ensures that a subclass can stand in for its superclass without causing errors or unexpected behavior.

## Interface Segregation Principle (ISP)
Clients should not be forced to depend on interfaces they do not use. This principle encourages the creation of smaller, more specific interfaces so that clients only need to know about the methods that are of interest to them.

## Dependency Inversion Principle (DIP)
High-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details. Details should depend on abstractions. This principle helps in reducing the coupling between different parts of the code.
