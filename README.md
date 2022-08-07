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
- [3. Principles](#3-principles)
  - [3.1. SRP - Single Responsibility Principle](#31-srp---single-responsibility-principle)
    - [3.1.1. Calculating responsibilities](#311-calculating-responsibilities)
    - [3.1.2. Common SRP Violation](#312-common-srp-violation)
    - [3.1.3. Design pattern Façade](#313-design-pattern-façade)
    - [3.1.4. Others related patterns](#314-others-related-patterns)
    - [3.1.5. Resume](#315-resume)
  - [3.2. O - Open/closed principle](#32-o---openclosed-principle)
    - [3.2.1. Why OCP?](#321-why-ocp)
    - [3.2.2. Single choice principle:](#322-single-choice-principle)
    - [3.2.3. Development methodologies​](#323-development-methodologies)
    - [3.2.4. Others related patterns](#324-others-related-patterns)
    - [3.2.5. Interfaces](#325-interfaces)
    - [3.2.6. Abstract Classes](#326-abstract-classes)
    - [3.2.7. Interfaces VS Abstract Classes​](#327-interfaces-vs-abstract-classes)
    - [3.2.8. Common Smells​](#328-common-smells)
    - [3.2.9. Adhering to OCP​](#329-adhering-to-ocp)
    - [3.2.10. Resume](#3210-resume)
  - [3.3. L - Liskov substitution principle](#33-l---liskov-substitution-principle)
    - [3.3.1. Ways of breaking substitutability​](#331-ways-of-breaking-substitutability)
    - [3.3.2. Contracts](#332-contracts)
      - [3.3.2.1. What is contract?](#3321-what-is-contract)
      - [3.3.2.2. What constitutes a method's contract?​](#3322-what-constitutes-a-methods-contract)
    - [3.3.3. Code contracts in C#​](#333-code-contracts-in-c)
    - [3.3.4. The problem of representatives​](#334-the-problem-of-representatives)
    - [3.3.5. Common Smells​](#335-common-smells)
    - [3.3.6. Tips](#336-tips)
  - [3.4. I - Interface Segregation Principle](#34-i---interface-segregation-principle)
    - [3.4.1. What is Interface?](#341-what-is-interface)
    - [3.4.2. Historical background](#342-historical-background)
    - [3.4.3. Common smells](#343-common-smells)
    - [3.4.4. Fixes](#344-fixes)
    - [3.4.5. Related patterns](#345-related-patterns)
    - [3.4.6. Adapter pattern](#346-adapter-pattern)
    - [3.4.7. Tips](#347-tips)
  - [3.5. D - Dependency inversion principle](#35-d---dependency-inversion-principle)
- [4. Meta principles](#4-meta-principles)
  - [4.1. DRY - Don't Repeat Yourself](#41-dry---dont-repeat-yourself)
    - [4.1.1. Common violations of DRY](#411-common-violations-of-dry)

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

# 3. Principles

## 3.1. SRP - Single Responsibility Principle

- Every object should have a ​single responsibility, ​and that responsibility ​should be entirely encapsulated ​by the class.
- This will be you can't think about that, a **class** can only be changed for the sake of the purpose, it is the responsibility that is imposed on that class.
- So that class has only one job to do.
- We can talk about all the class and this class, only responsible one job and do not do anything else inside of that class or into the methods.
- _There should never be more than one reason for a class to change._ Robert C. Martin aka Uncle Bob

### 3.1.1. Calculating responsibilities

- Axes of changing requirements​.
- API users are the source of changes.
- More responsibilities a class has, ​the more likely it's going to be changed.
- Classes with too many responsibilities ​are hard to understand!
- When SRP is violated, responsibilities ​start to collate with each other. ​They become coupled.
- Gather all the same responsibilities together and separate from each other those which are different.
- A set of functions or an interface ​is considered cohesive ​when each function ​is closely related to another.
- Coupling indicates ​how dependent modules are ​on the inner working of each other.

### 3.1.2. Common SRP Violation

- Mixing logic and infrastructure​.
- A class or a module serves different layers.

### 3.1.3. Design pattern Façade

- Applying the SRP leads to appearance of many small classes​.
  - It is hard to understand the API of too many small classes​.
    - "Façade" design pattern may come to the rescue.
- Façade​
  - The Façade's responsibility ​is to bring the functionality ​required by a client together.
  - Reasons for applying Façade​:
    - Provide for a client a simple API for interaction with a set of complex objects.
    - Provide for a client a cleaner API for interaction with poorly designed API.

### 3.1.4. Others related patterns

- Decorator​
  - Decorator allows the behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class.
- Composite
  - Composite pattern allows to compose objects into tree structures to represent part-whole hierarchies, letting clients treat individual objects and compositions of objects uniformly.

### 3.1.5. Resume

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

## 3.2. O - Open/closed principle

- Software entities should be open for extension, but closed for modification.
- We should be able to introduce a change by adding new code, not by changing the existing.
- **Polymorphism is the Answer.​**

### 3.2.1. Why OCP?

- There is a high chance of introducing bugs ​during the modification process​.
- It's hard to modify the behavior of an API ​which is already in use by many clients.
- When customers ask for a new feature they think that features will be added, they don't think that developers will modify anything.
- We must modify the existing code if it contains a bug.​
- The Protected Variation pattern means the following: ​Identify points of predicted variation and create a stable interface around them.

### 3.2.2. Single choice principle:

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

### 3.2.3. Development methodologies​

- Waterfall​
  - Try to foresee all the possible details​.
- Agile
  - Iterative development process with high involvement of a customer​.

### 3.2.4. Others related patterns

- Template Method
  - It defines the skeleton of an algorithm in an operation, deferring some steps to subclasses.
  - Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
- Strategy
  - Strategy enables an algorithm's behavior to be selected at runtime. ​The strategy pattern:
    - Defines a family of algorithms​.
    - Encapsulates each algorithm​.
    - Makes the algorithms interchangeable within that family​.
- **Specification**

### 3.2.5. Interfaces

- Interfaces can't be easily changed without breaking existing clients​.
- Interfaces are easily extendable by clients.
- In other words...
  - An interface is suppler from the client's perspective: any class can implement as many interfaces as it wants to​.
  - An interface is more rigid from the developer's perspective: it can't be easily changed and it does not support any kind of reusability.

### 3.2.6. Abstract Classes

- Supports reusability​.
- Supports encapsulation.​
- Can be extended easily without breaking existing clients.
- In other words...
  - An abstract class is supple from the developer's perspective​.
  - An abstract class is rigid from the client's perspective.

### 3.2.7. Interfaces VS Abstract Classes​

- Use abstract classes for building internal APIs​
- Use interfaces for providing external points of extension.
- In other words...
  - An abstract class is supple from the developer's perspective​.
  - An abstract class is rigid from the client's perspective.

### 3.2.8. Common Smells​

- Many conditional branches with if\else or switch\case statements.​

### 3.2.9. Adhering to OCP​

- Parameterization with delegates. "Chain of Responsibility" design pattern.​
- Classic Inheritance or "Visitor" design pattern​.
- Composition VS Inheritance. "Strategy" design pattern.

### 3.2.10. Resume

- Design should be open for extensions and closed for modification​.
- Isolate a responsibility for creating objects in a single module​ (Single Choice Principle)​.
- Related patterns: "Template Method" and "Strategy"​.
- Interface is suppler from the client's perspective​.
- Abstract class is suppler from the developer's perspective​.
- To overcome the problem of predicting the future, we rely on "agile design".

## 3.3. L - Liskov substitution principle

- If **S** is a subtype of **T**, then objects of type **T** may be replaced with objects of type **S**, without breaking the program.
- The Liskov Substitution Principle states that Subtypes must be substitutable for their base types.
- And the third one is the Liskov substitution principle, we should able to use subclasses instead of the upper classes from which they derive without needing to make any changes in our code.
- So that means we can use **interfaces** which are changing to any implementation code.
- These interfaces can be manage with the substitution each other.

### 3.3.1. Ways of breaking substitutability​

- Violating a Contract​.
- Violating Covariance\Contravariance.

### 3.3.2. Contracts

- Programming to Contracts was elaborated by Bertrand Meyer​ [DbC](https://en.wikipedia.org/wiki/Design_by_contract).
  - "Object-Oriented Software Construction" by Meyer is recommended​.
  - Eiffel [Eiffel](<https://en.wikipedia.org/wiki/Eiffel_(programming_language)>).

#### 3.3.2.1. What is contract?

- Contracts have some semantic payload​.
- Interfaces have no any semantic payload.
- **Interfaces are not Contracts​.**

#### 3.3.2.2. What constitutes a method's contract?​

- Acceptable and unacceptable input values or types, and their meanings​.
- Return values or types, and their meanings​.
- Error and exception condition values or types that can occur, and their meanings​.
- Side effects​.
- Preconditions​.
- Postconditions​.
- Invariants.

### 3.3.3. Code contracts in C#​

- You can write contracts in C# with a library called "Code Contracts". ​Harness the power of static code verification on correctness [CodeContracts](https://docs.microsoft.com/en-us/dotnet/framework/debug-trace-profile/code-contracts).​
- "Code Contracts" library is not very popular.

### 3.3.4. The problem of representatives​

- OOP can't directly map the relationships between objects in the real world into the same model of relationships between them in code​.
- Child classes implement IS-A relationship with base classes - ​naive statement of OOP​.
- Inheritors can require less and guarantee more but not vice-versa​.
- Refused Bequest​.
- Programming code just represents the concepts of square and rectangle.

### 3.3.5. Common Smells​

- Method throws NotSupportedException​.
- Empty or degenerative implementation​.
- Downcasts.

### 3.3.6. Tips

- Tell, Don't Ask principle​
- LSP if often the result of OCP or ISP violations​
- If two classes share some logic and they are not substitutable​
  - Create new base class​
  - Inherit those two classes from a base class ​
  - Ensure that they are substitutable with the new base class

## 3.4. I - Interface Segregation Principle

- ISP states that Clients should not be forced to depend on methods they do not use.
  - Prefer small, cohesive interfaces.
- ISP violations result in classes that depend on things they do not need, increasing coupling and reducing flexibility and maintainability.

### 3.4.1. What is Interface?

- `Interface` is a reserved keywork in C# which allows to declare a non-implementable type consisting of member signatures.
- Defines an API.
- Public API of a class is an interface.

### 3.4.2. Historical background

- First public formulation belong to Uncle Bob.
- Uncle Bob applied ISP working for xerox.
- That was a printing system.

### 3.4.3. Common smells

- LSP violation smell often indicates a violation of ISP.

### 3.4.4. Fixes

- Client's code references a class but uses only a small portion of its API
  - Fat interface => Segregate it
  - Fat interface which is not under your control => Facade pattern

### 3.4.5. Related patterns

- Adapter pattern
- Facade

### 3.4.6. Adapter pattern

- Convert the interface of a class into another interface clients expect.
- Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

### 3.4.7. Tips

- General algorithm of "fixing" fat interfaces:
  - Create narrower interface.
  - Fat interface inherits from that narrow interface.
  - Client uses narrow interface.
- Don't abuse ISP by creating tons of small interfaces.
- Keep an interface within the client's assembly if possible.

## 3.5. D - Dependency inversion principle

- Dependencies between classes should be as low as possible, and especially upper classes should not be dependent on the lower classes.
- But these are the main principles and all these principles is very similar to each other.
- We have some connection with these principles, but we can see that how we can apply these principles one by one when we are developing Ordering microservices.

- Types of injection
  - Constructor injection (Best approach):
    - To be passed via constructor by client e.g.: `var registerCard = new RegisterCardRepository(new RegisterCard)`.
  - Property injection:
    - To be passed via property by client e.g.: `IRegisterCard RegisterCard { get; set; }`.
  - Method injection:
    - To be passed via method by client e.g.: `public void RegisterCard(Card card, Client client) { ... }`.

# 4. Meta principles

## 4.1. DRY - Don't Repeat Yourself

- A substantial number of bugs in software are caussed by repetitive code.
- Every piece of knowledge must have a single, unambiguous representation in the system.

### 4.1.1. Common violations of DRY

- Magic strings or any other magic values.
- Duplicate logic in multiple locations.
- Repeated `if-then` logic or multiple switch-cases scattered throughout the code base.

- Examples with magic values:

  - Bad:

  ```
  int reponseCode = GetDeviceResponse();
  if (responseCode == 188)
  {

  }
  ```

  - Good:

  ```
  const int NoConnection = 188;
  int reponseCode = GetDeviceResponse();
  if (responseCode == NoConnection)
  {

  }
  ```

  ***

  - Bad:

  ```
  public class MagicValues
  {
  	public void AcceptCard()
  	{
  		var d = new Device();
  		d.SendCommand(1);
  		d.SendCommand(2);
  		d.SendCommand(9);
  	}

  	public void DispenseCard()
  	{
  		var d = new Device();
  		d.SendCommand(1);
  		d.SendCommand(3);
  		d.SendCommand(9);​
  	}
  }
  ```

  - Good:

  ```
  public class NoMagic
  {
  	private const int Initialize = 1;
  	private const int Terminate = 9;

  	public void AcceptCard()
  	{
  		var d = new Device();
  		d.SendCommand(Initialize);
  		d.SendCommand(2);
  		d.SendCommand(Terminate);
  	}

  	public void DispenseCard()
  	{
  		var d = new Device();
  		d.SendCommand(Initialize);
  		d.SendCommand(3);
  		d.SendCommand(Terminate);
  	}
  }
  ```

  - Good without duplicated code:

  ```
  public class NoDuplicateLogic {
  	private const int Initialize = 1;
  	private const int Terminate = 9;

  	public void AcceptCard() {
  		ExecuteCommand(2);
  	}

  	public void DispenseCard() {
  		ExecuteCommand(3);
  	}

  	private void ExecuteCommand(byte command) {
  		var d = new Device();
  		d.SendCommand(Initialize);
  		d.SendCommand(command);
  		d.SendCommand(Terminate);
  	}
  }
  ```
