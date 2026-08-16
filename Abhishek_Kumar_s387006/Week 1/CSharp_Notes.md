# C# Notes

## 1. Introduction to C#

C# is a programming language commonly used with the .NET platform for building applications.

## 2. C# and .NET

- **C#:** The programming language used to write the application code.
- **.NET:** A development platform/runtime used to build and run applications written in C# and other supported languages.

## 3. Basic C# Concepts

### Variables
Variables are used to store data.

Common data types include:
- `int`
- `double`
- `float`
- `decimal`
- `char`
- `string`
- `bool`

Example:

```csharp
int age = 25;
string name = "Sunil";
bool isActive = true;
```

### Operators

Common operators include:
- Arithmetic: `+`, `-`, `*`, `/`, `%`
- Comparison: `==`, `!=`, `>`, `<`, `>=`, `<=`
- Logical: `&&`, `||`, `!`
- Assignment: `=`, `+=`, `-=`, `*=`, `/=`

### Conditional Statements

Common conditional statements:
- `if`
- `else`
- `else if`
- `switch`

Example:

```csharp
if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Minor");
}
```

### Loops

Common loops:
- `for`
- `while`
- `do-while`
- `foreach`

Example:

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

### Methods

Methods are reusable blocks of code that perform a particular task.

```csharp
static int Add(int a, int b)
{
    return a + b;
}
```

## 4. Object-Oriented Programming

Important OOP concepts to study:
- Class
- Object
- Encapsulation
- Inheritance
- Polymorphism
- Abstraction

Example:

```csharp
class Car
{
    public string Brand;

    public void Start()
    {
        Console.WriteLine("Car started");
    }
}
```

## 5. Collections

Common C# collections include:
- Array
- `List<T>`
- `Dictionary<TKey, TValue>`
- `HashSet<T>`

## 6. Exception Handling

C# provides exception handling using:
- `try`
- `catch`
- `finally`
- `throw`

Example:

```csharp
try
{
    int result = 10 / 0;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

## 7. Learning Approach

- Covered the theoretical fundamentals of C# and .NET.
- Went through relevant theory and learning material.
- Reviewed the concepts before practical implementation.
- Used online learning resources to strengthen understanding.

## 8. Learning Resource

- [C# Tutorial](https://youtu.be/SuLiu5AK9Ps?si=xhXefj-o0ywN27-h)
