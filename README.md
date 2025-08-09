# dcit318-assignment2-11210385

# C# OOP Examples

This repository contains three C# programs that demonstrate **key Object-Oriented Programming (OOP) concepts**:

1. **Inheritance & Method Overriding**  
2. **Abstract Classes & Methods**  
3. **Interfaces**  


## 1. Inheritance & Method Overriding
**Description:**  
Demonstrates how a derived class can override a method from its base class.  
Example: A base class `Animal` has a method `MakeSound()`.  
Derived classes `Dog` and `Cat` override this method to produce different sounds.


## 2. Abstract Classes & Methods
**Description:**  
Shows how to use abstract classes to enforce method implementation in derived classes.  
Example: An abstract class `Shape` has an abstract method `GetArea()`.  
Derived classes `Circle` and `Rectangle` implement `GetArea()` to calculate their specific areas.


## 3. Interfaces
**Description:**  
Shows how to define and implement an interface in multiple classes.  
Example: An interface `IMovable` defines a method `Move()`.  
Classes `Car` and `Bicycle` implement `Move()` differently.

---

## How to Run
1. Save the desired C# program in a `.cs` file.
2. Compile using:
   ```bash
   csc filename.cs

## Key Concepts Learned
**Inheritance:** Sharing and customizing behavior in derived classes.

**Method Overriding:** Changing base class behavior in child classes.

**Abstract Classes:** Enforcing a contract for derived classes.

**Interfaces:** Defining behavior without implementation.