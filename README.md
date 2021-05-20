# StrategyPattern
> This project aims to show how strategy pattern can be implemented in a real life situation, using dotnet core and C#.

## Table of Contents
* [Introducing Strategy Pattern](#introducing-strategy-pattern)
* [Pros and Cons](#pros-and-cons)
* [Problems solved with this pattern](#problems-solved-with-this-pattern)
* [Real Life Implementation](#Real-life-implementation)

## Introducing Strategy Pattern
[Strategy Pattern](https://en.wikipedia.org/wiki/Strategy_pattern) is a behavioral software design pattern that enables selecting an algorithm at runtime. Instead of implementing a single algorithm directly, code receives run-time instructions as to which in a family of algorithms to use.

## Pros and Cons
✅ You can swap algorithms used inside an object at runtime.
✅ You can isolate the implementation details of an algorithm from the code that uses it.
✅ You can replace inheritance with composition.
✅ Open/Closed Principle. You can introduce new strategies without having to change the context.

❌ If you only have a couple of algorithms and they rarely change, there’s no real reason to overcomplicate the program with new classes and interfaces that come along with the pattern.
❌ Clients must be aware of the differences between strategies to be able to select a proper one.
❌ A lot of modern programming languages have functional type support that lets you implement different versions of an algorithm inside a set of anonymous functions. Then you could use these functions exactly as you’d have used the strategy objects, but without bloating your code with extra classes and interfaces.

[See More](https://refactoring.guru/design-patterns/strategy)

