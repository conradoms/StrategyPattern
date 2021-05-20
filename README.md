# StrategyPattern 🎯
> This project aims to show how strategy pattern can be implemented in a real life situation, using dotnet core and C#.

> Complexity: ★☆☆

> Popularity: ★★★

## Table of Contents
* [Introducing Strategy Pattern](#introducing-strategy-pattern)
* [Pros and Cons](#pros-and-cons)
* [When to use](#when-to-use)
* [Real Life Implementation](#real-life-implementation)
* [Contact](#contact)

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

## When To Use
📌 Use the Strategy pattern when you want to use different variants of an algorithm within an object and be able to switch from one algorithm to another during runtime.

📌 Use the Strategy when you have a lot of similar classes that only differ in the way they execute some behavior.

📌 Use the pattern to isolate the business logic of a class from the implementation details of algorithms that may not be as important in the context of that logic.

📌 Use the pattern when your class has a massive conditional operator that switches between different variants of the same algorithm.

## Real Life Implementation

### Class Diagram

![StrategyPattern](https://user-images.githubusercontent.com/5831318/119040941-62dad280-b98c-11eb-8a3a-43e06b024383.png)

### Solution Description

This application simulates a service for calculating freight. The calculation method takes two parameters: Package weight and code of the desired logistics company.

In the presented scenario, a very common problem in real applications may arise: How to select a specific runtime algorithm according to the user input parameters and keep the application code maintainable, open for expansion and without hurting the SOLID principles?

Before implementing a possible solution, in the first commits of the main branch it is possible to view the implementation of the problem before refactoring.
The proposed solution implements the Strategy design pattern. This choice was made in order to avoid the indiscriminate use of IF or Switch Case clauses to select the calculation strategy by company and to encapsulate the calculation rules, thus facilitating the inclusion of new calculation strategies and unit tests.

In this project, the ShippingService class is used by the ShippingController controller and is responsible for calculating the fee. This class uses the Factory pattern to abstract and encapsulate the creation of strategy objects and to decrease coupling. The strategy objects implement the IShippingStrategy interface, which in turn defines a contract where the Calculate method must be present in all classes that implement this interface. The Create method of the ShippingStrategyFactory class receives the code of the desired company as a parameter and provides the class instance that contains the company's calculation strategy. After obtaining the desired calculation strategy according to the company code, the CalculateShippingFee method of the ShippingService class invokes the Calculate method of the acquired strategy and returns the result to the controller.

## Contact
> Created by [Conrado Silva](mailto:conradoms@gmail.com) - Feel free to contact me. 🤓
