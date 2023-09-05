# Mosh Course on The Ultimate C# Series: Part 3

## Generics

constrains

- IComparable (interface)
- Product (type)
- struct (value type)
- class (ref type)
- new() (default constructor)

## Delegates

An object that knows how to call a method (or a group of methods)
A reference to a function

- Why do we need delegates

  - For designing extensible and flexible applications (eg frameworks)

- Predefined delegates are
  - Action : supports methods that returns void
  - Func : supports methods that returns a value

Interfaces or Delegates?

- Use a delegate when
  - An eventing design pattern is used.
  - The caller doesn't need to access other properties or methods on the object implementing the method.

## Lambda Expression

An anonymous method

- No access modifier
- No name
- No return statement

Why do we use them?

- For convenience
- args => expression
- () => ...
- x => ...
- (x, y, z) => ...

What is Predicate?
It is a delegate that takes ONE input and returns boolean value

## Events and Delegates

- A mechanism for communication between objects
- Used in building lossely coupled applications
- Helps extending applications

Delegate

- Agreement/Contract between Published and Subscriber
- Determines the signature of the event handler method in subscriber

## Extension Methods

Allow us to add methods to an existing class without

- changing its source code, or
- creating a new class that inherits from it

- Extension methods must be in static class: public static class StringExtensions
- method should be public static and 1st argument should be "this String str"

# Linq

What is LINQ?

- Stands for: Language Integrated Query
- Gives you the capability to query objects

You can query

- Objects in memory, eg collections (LINQ to Objects)
- Databases (LINQ to Entites)
- XML (LINQ to XML)
- ADO.NET Data Sets (LINQ to Data Sets)

# Nullable

Value Types

- Cannot be null
- bool hasAccess = true; // or false

# Exception Handling

Using key word will call the dispose method of a class

# Async/Await

Asynchronous programming inproves responsiveness
