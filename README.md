# Solid and meta principles overview <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. Intro](#1-intro)
  - [1.1. Building software](#11-building-software)
  - [1.2. Design smells](#12-design-smells)
  - [1.3. Design principles - SOLID](#13-design-principles---solid)
  - [1.4. Dependency Management](#14-dependency-management)
- [2. What is SOLID?​](#2-what-is-solid)
  - [2.1. How SOLID improve OO-programming skills​](#21-how-solid-improve-oo-programming-skills)
  - [2.2. Why we need SOLID?​](#22-why-we-need-solid)
  - [2.3. SRP - Single Responsibility Principle](#23-srp---single-responsibility-principle)
    - [2.3.1. Calculating responsibilities](#231-calculating-responsibilities)
    - [2.3.2. Common SRP Violation](#232-common-srp-violation)
    - [2.3.3. Design pattern Façade](#233-design-pattern-façade)
    - [2.3.4. Others related patterns](#234-others-related-patterns)
    - [2.3.5. Resume](#235-resume)
  - [2.4. O - Open/closed principle](#24-o---openclosed-principle)
    - [2.4.1. Why OCP?](#241-why-ocp)
    - [2.4.2. Single choice principle:](#242-single-choice-principle)
    - [2.4.3. Development methodologies​](#243-development-methodologies)
    - [2.4.4. Others related patterns](#244-others-related-patterns)
    - [2.4.5. Interfaces](#245-interfaces)
    - [2.4.6. Abstract Classes](#246-abstract-classes)
    - [2.4.7. Interfaces VS Abstract Classes​](#247-interfaces-vs-abstract-classes)
    - [2.4.8. Common Smells​](#248-common-smells)
    - [2.4.9. Adhering to OCP​](#249-adhering-to-ocp)
    - [2.4.10. Resume](#2410-resume)
  - [2.5. L - Liskov substitution principle](#25-l---liskov-substitution-principle)
    - [2.5.1. Ways of breaking substitutability​](#251-ways-of-breaking-substitutability)
    - [2.5.2. Contracts](#252-contracts)
      - [2.5.2.1. What is contract?](#2521-what-is-contract)
      - [2.5.2.2. What constitutes a method's contract?​](#2522-what-constitutes-a-methods-contract)
    - [2.5.3. Code contracts in C#​](#253-code-contracts-in-c)
    - [2.5.4. The problem of representatives​](#254-the-problem-of-representatives)
    - [2.5.5. Common Smells​](#255-common-smells)
    - [2.5.6. Tips](#256-tips)
  - [2.6. I - Interface Segregation Principle](#26-i---interface-segregation-principle)
    - [2.6.1. What is Interface?](#261-what-is-interface)
    - [2.6.2. Historical background](#262-historical-background)
    - [2.6.3. Common smells](#263-common-smells)
    - [2.6.4. Fixes](#264-fixes)
    - [2.6.5. Related patterns](#265-related-patterns)
    - [2.6.6. Adapter pattern](#266-adapter-pattern)
    - [2.6.7. Tips](#267-tips)
  - [2.7. D - Dependency inversion principle](#27-d---dependency-inversion-principle)

# 1. Intro

## 1.1. Building software

- Big design upfront is ​very expensive in software development​.
- No guarantee that we ​take into account all the possible requirements.
- Requirements tend to change very quickly .
- Keep the design as clean as you can.

## 1.2. Design smells

- Rigidity​:
  - Software is rigid ​if the cost of making a single change is very high​
    - **Reason - tight coupling between modules.**
- Fragility​:
  - Software is fragile if small changes ​in one module cause bugs appearance in other​.
    - **Reason – tight coupling between components.**
- Immobility​:
  - Software is immobile when ​it's components can't be reused in other systems​.
    - **Reason - tight coupling between components.**
- Viscosity​:
  - The software is viscose when adding a single feature evokes dealing with tons of aspects​.
    - **Reason - tight coupling between components.**
- Needless Complexity:
  - Software is needlessly complex if ​developers are trying to forecast the future, ​introducing excessive points of extension​.
  - Concentrate on the current requirements, ​constructing the supple architecture ​which can bend to meet new requirements.

## 1.3. Design principles - SOLID

- SOLID software principles, is the set of principles put forward by **Robert C. Martin**, which ensures that the software developed is flexible, reusable, sustainable and understandable, prevents code repetition.
- Frequently references in Design Pattern literature.
- So the main purpose of these principles, in order to easily adapted to requirements in the future and easier to add new features without the need to change anything in your code and also minimal change in code despite the new requirements and minimize the loss of time caused by the problems, such as the continuous correction on the code or even re-writing to code.
- Not bound to any technology​
- SOLID is not a goal​
- "SOLIDness" is not measurable

## 1.4. Dependency Management

- OO-languages can harness ​the power of dynamic dispatch​.
- Proper dependency management - key to a good architecture.

# 2. What is SOLID?​

- SOLID stands for SRP, OCP, LSP, and DIP:
  - Single Responsibility Principle​.
  - Open/Closed Principle​.
  - Liskov Substitution Principle​.
  - Interface Segregation Principle.​
  - Dependency Inversion Principle.

## 2.1. How SOLID improve OO-programming skills​

- Meta principles on which all the other ​development principles are based​.
- Symptoms of code defects​.
- Foundations of SOLID principles​.
- Detect the violations of SOLID principles and how to fix the problems​.
- How meta and SOLID principles are related to each other ​and how to find the balance between them.

## 2.2. Why we need SOLID?​

- Poor design is a regular case​.
- Powerful programming language doesn't guarantee good design​.
- Designing skills are prerequisite for serious programming.

## 2.3. SRP - Single Responsibility Principle

- Every object should have a ​single responsibility, ​and that responsibility ​should be entirely encapsulated ​by the class.
- This will be you can't think about that, a **class** can only be changed for the sake of the purpose, it is the responsibility that is imposed on that class.
- So that class has only one job to do.
- We can talk about all the class and this class, only responsible one job and do not do anything else inside of that class or into the methods.
- _There should never be more than one reason for a class to change._ Robert C. Martin aka Uncle Bob

### 2.3.1. Calculating responsibilities

- Axes of changing requirements​.
- API users are the source of changes.
- More responsibilities a class has, ​the more likely it's going to be changed.
- Classes with too many responsibilities ​are hard to understand!
- When SRP is violated, responsibilities ​start to collate with each other. ​They become coupled.
- Gather all the same responsibilities together and separate from each other those which are different.
- A set of functions or an interface ​is considered cohesive ​when each function ​is closely related to another.
- Coupling indicates ​how dependent modules are ​on the inner working of each other.

### 2.3.2. Common SRP Violation

- Mixing logic and infrastructure​.
- A class or a module serves different layers.

### 2.3.3. Design pattern Façade

- Applying the SRP leads to appearance of many small classes​.
  - It is hard to understand the API of too many small classes​.
    - "Façade" design pattern may come to the rescue.
- Façade​
  - The Façade's responsibility ​is to bring the functionality ​required by a client together.
  - Reasons for applying Façade​:
    - Provide for a client a simple API for interaction with a set of complex objects.
    - Provide for a client a cleaner API for interaction with poorly designed API.

### 2.3.4. Others related patterns

- Decorator​
  - Decorator allows the behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class.
- Composite
  - Composite pattern allows to compose objects into tree structures to represent part-whole hierarchies, letting clients treat individual objects and compositions of objects uniformly.

### 2.3.5. Resume

- Applying SRP we want to separate different concerns.
- A class should do one thing, and do it well!​
- Apply SRP at different levels:
  - function
  - object
  - module​
- Classes with many responsibilities are hard to understand.​
- When SRP is violated, responsibilities start to collate with each other​.
- Don't abuse the SRP​.
- Apply Façade pattern to simplify the API​.
- Modules that change frequently should be isolated ​from the other parts of the system.

## 2.4. O - Open/closed principle

- Software entities should be open for extension, but closed for modification.
- We should be able to introduce a change by adding new code, not by changing the existing.
- **Polymorphism is the Answer.​**

### 2.4.1. Why OCP?

- There is a high chance of introducing bugs ​during the modification process​.
- It's hard to modify the behavior of an API ​which is already in use by many clients.
- When customers ask for a new feature they think that features will be added, they don't think that developers will modify anything.
- We must modify the existing code if it contains a bug.​
- The Protected Variation pattern means the following: ​Identify points of predicted variation and create a stable interface around them.

### 2.4.2. Single choice principle:

```
    public class BankTerminalFactory​
    {​
        public static IBankTerminal CreateBankTerminal(BankTerminalModel model)​
        {​
            switch (model)​
            {​
                case BankTerminalModel.Brp:​
                    return new BrpTerminal();​
                case BankTerminalModel.Dcp:​
                    return new DcpTerminal();​
                default:​
                    throw new ArgumentException("Unknown model");​
            }​
        }​
    }
```

- We can't achieve a super-supple design which allows to introduce any possible features.

### 2.4.3. Development methodologies​

- Waterfall​
  - Try to foresee all the possible details​.
- Agile
  - Iterative development process with high involvement of a customer​.

### 2.4.4. Others related patterns

- Template Method
  - It defines the skeleton of an algorithm in an operation, deferring some steps to subclasses.
  - Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
- Strategy
  - Strategy enables an algorithm's behavior to be selected at runtime. ​The strategy pattern:
    - Defines a family of algorithms​.
    - Encapsulates each algorithm​.
    - Makes the algorithms interchangeable within that family​.
- **Specification**

### 2.4.5. Interfaces

- Interfaces can't be easily changed without breaking existing clients​.
- Interfaces are easily extendable by clients.
- In other words...
  - An interface is suppler from the client's perspective: any class can implement as many interfaces as it wants to​.
  - An interface is more rigid from the developer's perspective: it can't be easily changed and it does not support any kind of reusability.

### 2.4.6. Abstract Classes

- Supports reusability​.
- Supports encapsulation.​
- Can be extended easily without breaking existing clients.
- In other words...
  - An abstract class is supple from the developer's perspective​.
  - An abstract class is rigid from the client's perspective.

### 2.4.7. Interfaces VS Abstract Classes​

- Use abstract classes for building internal APIs​
- Use interfaces for providing external points of extension.
- In other words...
  - An abstract class is supple from the developer's perspective​.
  - An abstract class is rigid from the client's perspective.

### 2.4.8. Common Smells​

- Many conditional branches with if\else or switch\case statements.​

### 2.4.9. Adhering to OCP​

- Parameterization with delegates. "Chain of Responsibility" design pattern.​
- Classic Inheritance or "Visitor" design pattern​.
- Composition VS Inheritance. "Strategy" design pattern.

### 2.4.10. Resume

- Design should be open for extensions and closed for modification​.
- Isolate a responsibility for creating objects in a single module​ (Single Choice Principle)​.
- Related patterns: "Template Method" and "Strategy"​.
- Interface is suppler from the client's perspective​.
- Abstract class is suppler from the developer's perspective​.
- To overcome the problem of predicting the future, we rely on "agile design".

## 2.5. L - Liskov substitution principle

- If **S** is a subtype of **T**, then objects of type **T** may be replaced with objects of type **S**, without breaking the program.
- The Liskov Substitution Principle states that Subtypes must be substitutable for their base types.
- And the third one is the Liskov substitution principle, we should able to use subclasses instead of the upper classes from which they derive without needing to make any changes in our code.
- So that means we can use **interfaces** which are changing to any implementation code.
- These interfaces can be manage with the substitution each other.

### 2.5.1. Ways of breaking substitutability​

- Violating a Contract​.
- Violating Covariance\Contravariance.

### 2.5.2. Contracts

- Programming to Contracts was elaborated by Bertrand Meyer​ [DbC](https://en.wikipedia.org/wiki/Design_by_contract).
  - "Object-Oriented Software Construction" by Meyer is recommended​.
  - Eiffel [Eiffel](<https://en.wikipedia.org/wiki/Eiffel_(programming_language)>).

#### 2.5.2.1. What is contract?

- Contracts have some semantic payload​.
- Interfaces have no any semantic payload.
- **Interfaces are not Contracts​.**

#### 2.5.2.2. What constitutes a method's contract?​

- Acceptable and unacceptable input values or types, and their meanings​.
- Return values or types, and their meanings​.
- Error and exception condition values or types that can occur, and their meanings​.
- Side effects​.
- Preconditions​.
- Postconditions​.
- Invariants.

### 2.5.3. Code contracts in C#​

- You can write contracts in C# with a library called "Code Contracts". ​Harness the power of static code verification on correctness [CodeContracts](https://docs.microsoft.com/en-us/dotnet/framework/debug-trace-profile/code-contracts).​
- "Code Contracts" library is not very popular.

### 2.5.4. The problem of representatives​

- OOP can't directly map the relationships between objects in the real world into the same model of relationships between them in code​.
- Child classes implement IS-A relationship with base classes - ​naive statement of OOP​.
- Inheritors can require less and guarantee more but not vice-versa​.
- Refused Bequest​.
- Programming code just represents the concepts of square and rectangle.

### 2.5.5. Common Smells​

- Method throws NotSupportedException​.
- Empty or degenerative implementation​.
- Downcasts.

### 2.5.6. Tips

- Tell, Don't Ask principle​
- LSP if often the result of OCP or ISP violations​
- If two classes share some logic and they are not substitutable​
  - Create new base class​
  - Inherit those two classes from a base class ​
  - Ensure that they are substitutable with the new base class

## 2.6. I - Interface Segregation Principle

- ISP states that Clients should not be forced to depend on methods they do not use.
  - Prefer small, cohesive interfaces.
- ISP violations result in classes that depend on things they do not need, increasing coupling and reducing flexibility and maintainability.

### 2.6.1. What is Interface?

- `Interface` is a reserved keywork in C# which allows to declare a non-implementable type consisting of member signatures.
- Defines an API.
- Public API of a class is an interface.

### 2.6.2. Historical background

- First public formulation belong to Uncle Bob.
- Uncle Bob applied ISP working for xerox.
- That was a printing system.

### 2.6.3. Common smells

- LSP violation smell often indicates a violation of ISP.

### 2.6.4. Fixes

- Client's code references a class but uses only a small portion of its API
  - Fat interface => Segregate it
  - Fat interface which is not under your control => Facade pattern

### 2.6.5. Related patterns

- Adapter pattern
- Facade

### 2.6.6. Adapter pattern

- Convert the interface of a class into another interface clients expect.
- Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

### 2.6.7. Tips

- General algorithm of "fixing" fat interfaces:
  - Create narrower interface.
  - Fat interface inherits from that narrow interface.
  - Client uses narrow interface.
- Don't abuse ISP by creating tons of small interfaces.
- Keep an interface within the client's assembly if possible.

## 2.7. D - Dependency inversion principle

- Dependencies between classes should be as low as possible, and especially upper classes should not be dependent on the lower classes.
- But these are the main principles and all these principles is very similar to each other.
- We have some connection with these principles, but we can see that how we can apply these principles one by one when we are developing Ordering microservices.
