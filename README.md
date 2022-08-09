# Solid and meta principles overview <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. Intro](#1-intro)
  - [1.1. Building software](#11-building-software)
  - [1.2. Design smells](#12-design-smells)
  - [1.3. Design principles - SOLID](#13-design-principles---solid)
  - [1.4. Dependency Management](#14-dependency-management)
- [2. What is SOLID?](#2-what-is-solid)
  - [2.1. How SOLID improve OO-programming skills](#21-how-solid-improve-oo-programming-skills)
  - [2.2. Why we need SOLID?](#22-why-we-need-solid)
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
    - [3.2.3. Development methodologies](#323-development-methodologies)
    - [3.2.4. Others related patterns](#324-others-related-patterns)
    - [3.2.5. Interfaces](#325-interfaces)
    - [3.2.6. Abstract Classes](#326-abstract-classes)
    - [3.2.7. Interfaces VS Abstract Classes](#327-interfaces-vs-abstract-classes)
    - [3.2.8. Common Smells](#328-common-smells)
    - [3.2.9. Adhering to OCP](#329-adhering-to-ocp)
    - [3.2.10. Resume](#3210-resume)
  - [3.3. L - Liskov substitution principle](#33-l---liskov-substitution-principle)
    - [3.3.1. Ways of breaking substitutability](#331-ways-of-breaking-substitutability)
    - [3.3.2. Contracts](#332-contracts)
      - [3.3.2.1. What is contract?](#3321-what-is-contract)
      - [3.3.2.2. What constitutes a method's contract?](#3322-what-constitutes-a-methods-contract)
    - [3.3.3. Code contracts in C#](#333-code-contracts-in-c)
    - [3.3.4. The problem of representatives](#334-the-problem-of-representatives)
    - [3.3.5. Common Smells](#335-common-smells)
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
    - [3.5.1. Types of Dependencies](#351-types-of-dependencies)
    - [3.5.2. Policy depends on Details](#352-policy-depends-on-details)
    - [3.5.3. Policy doesn't depend on Details](#353-policy-doesnt-depend-on-details)
    - [3.5.4. Volatile and Stable Dependencies](#354-volatile-and-stable-dependencies)
      - [3.5.4.1. Volatile Dependencies](#3541-volatile-dependencies)
    - [3.5.5. Definitions of IoC and DI](#355-definitions-of-ioc-and-di)
      - [3.5.5.1. Inversion of Control (IoC)](#3551-inversion-of-control-ioc)
      - [3.5.5.2. DIP](#3552-dip)
    - [3.5.6. IoC and DI](#356-ioc-and-di)
    - [3.5.7. DI Techniques](#357-di-techniques)
      - [3.5.7.1. Constructor Injection](#3571-constructor-injection)
        - [3.5.7.1.1. Possible pitfall](#35711-possible-pitfall)
      - [3.5.7.2. Property Injection](#3572-property-injection)
        - [3.5.7.2.1. Possible pitfall](#35721-possible-pitfall)
      - [3.5.7.3. Method Injection](#3573-method-injection)
        - [3.5.7.3.1. Pitfalls](#35731-pitfalls)
    - [3.5.8. Architectural Implications](#358-architectural-implications)
      - [3.5.8.1. Application Boundaries](#3581-application-boundaries)
      - [3.5.8.2. Data-Centric Model](#3582-data-centric-model)
      - [3.5.8.3. Domain-Centric Model](#3583-domain-centric-model)
      - [3.5.8.4. Enlarged Domain-Centric Model](#3584-enlarged-domain-centric-model)
      - [3.5.8.5. Pure DI and IoC-Containers](#3585-pure-di-and-ioc-containers)
        - [3.5.8.5.1. IoC-Containers](#35851-ioc-containers)
      - [3.5.8.6. Common Smells](#3586-common-smells)
- [4. Meta principles](#4-meta-principles)
  - [4.1. DRY - Don't Repeat Yourself](#41-dry---dont-repeat-yourself)
    - [4.1.1. Common violations of DRY](#411-common-violations-of-dry)
  - [4.2. KISS - Keep it Simple, Stupid](#42-kiss---keep-it-simple-stupid)
    - [4.2.1. What is Simplicity?](#421-what-is-simplicity)
    - [4.2.2. Accidental & Essential Complexity](#422-accidental--essential-complexity)
    - [4.2.3. Achieving Simplicity](#423-achieving-simplicity)
    - [4.2.4. Simplicity](#424-simplicity)

# 1. Intro

## 1.1. Building software

- Big design upfront is very expensive in software development.
- No guarantee that we take into account all the possible requirements.
- Requirements tend to change very quickly .
- Keep the design as clean as you can.

## 1.2. Design smells

- Rigidity:
  - Software is rigid if the cost of making a single change is very high
    - **Reason - tight coupling between modules.**
- Fragility:
  - Software is fragile if small changes in one module cause bugs appearance in other.
    - **Reason – tight coupling between components.**
- Immobility:
  - Software is immobile when it's components can't be reused in other systems.
    - **Reason - tight coupling between components.**
- Viscosity:
  - The software is viscose when adding a single feature evokes dealing with tons of aspects.
    - **Reason - tight coupling between components.**
- Needless Complexity:
  - Software is needlessly complex if developers are trying to forecast the future, introducing excessive points of extension.
  - Concentrate on the current requirements, constructing the supple architecture which can bend to meet new requirements.

## 1.3. Design principles - SOLID

- SOLID software principles, is the set of principles put forward by **Robert C. Martin**, which ensures that the software developed is flexible, reusable, sustainable and understandable, prevents code repetition.
- Frequently references in Design Pattern literature.
- So the main purpose of these principles, in order to easily adapted to requirements in the future and easier to add new features without the need to change anything in your code and also minimal change in code despite the new requirements and minimize the loss of time caused by the problems, such as the continuous correction on the code or even re-writing to code.
- Not bound to any technology.
- SOLID is not a goal.
- "SOLIDness" is not measurable.

## 1.4. Dependency Management

- OO-languages can harness the power of dynamic dispatch.
- Proper dependency management - key to a good architecture.

# 2. What is SOLID?

- SOLID stands for SRP, OCP, LSP, and DIP:
  - Single Responsibility Principle.
  - Open/Closed Principle.
  - Liskov Substitution Principle.
  - Interface Segregation Principle.
  - Dependency Inversion Principle.

## 2.1. How SOLID improve OO-programming skills

- Meta principles on which all the other development principles are based.
- Symptoms of code defects.
- Foundations of SOLID principles.
- Detect the violations of SOLID principles and how to fix the problems.
- How meta and SOLID principles are related to each other and how to find the balance between them.

## 2.2. Why we need SOLID?

- Poor design is a regular case.
- Powerful programming language doesn't guarantee good design.
- Designing skills are prerequisite for serious programming.

# 3. Principles

## 3.1. SRP - Single Responsibility Principle

- Every object should have a single responsibility, and that responsibility should be entirely encapsulated by the class.
- This will be you can't think about that, a **class** can only be changed for the sake of the purpose, it is the responsibility that is imposed on that class.
- So that class has only one job to do.
- We can talk about all the class and this class, only responsible one job and do not do anything else inside of that class or into the methods.
- _There should never be more than one reason for a class to change._ Robert C. Martin aka Uncle Bob

### 3.1.1. Calculating responsibilities

- Axes of changing requirements.
- API users are the source of changes.
- More responsibilities a class has, the more likely it's going to be changed.
- Classes with too many responsibilities are hard to understand!
- When SRP is violated, responsibilities start to collate with each other. They become coupled.
- Gather all the same responsibilities together and separate from each other those which are different.
- A set of functions or an interface is considered cohesive when each function is closely related to another.
- Coupling indicates how dependent modules are on the inner working of each other.

### 3.1.2. Common SRP Violation

- Mixing logic and infrastructure.
- A class or a module serves different layers.

### 3.1.3. Design pattern Façade

- Applying the SRP leads to appearance of many small classes.
  - It is hard to understand the API of too many small classes.
    - "Façade" design pattern may come to the rescue.
- Façade:
  - The Façade's responsibility is to bring the functionality required by a client together.
  - Reasons for applying Façade:
    - Provide for a client a simple API for interaction with a set of complex objects.
    - Provide for a client a cleaner API for interaction with poorly designed API.

### 3.1.4. Others related patterns

- Decorator
  - Decorator allows the behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class.
- Composite
  - Composite pattern allows to compose objects into tree structures to represent part-whole hierarchies, letting clients treat individual objects and compositions of objects uniformly.

### 3.1.5. Resume

- Applying SRP we want to separate different concerns.
- A class should do one thing, and do it well!
- Apply SRP at different levels:
  - function
  - object
  - module
- Classes with many responsibilities are hard to understand.
- When SRP is violated, responsibilities start to collate with each other.
- Don't abuse the SRP.
- Apply Façade pattern to simplify the API.
- Modules that change frequently should be isolated from the other parts of the system.

## 3.2. O - Open/closed principle

- Software entities should be open for extension, but closed for modification.
- We should be able to introduce a change by adding new code, not by changing the existing.
- **Polymorphism is the Answer.**

### 3.2.1. Why OCP?

- There is a high chance of introducing bugs during the modification process.
- It's hard to modify the behavior of an API which is already in use by many clients.
- When customers ask for a new feature they think that features will be added, they don't think that developers will modify anything.
- We must modify the existing code if it contains a bug.
- The Protected Variation pattern means the following: Identify points of predicted variation and create a stable interface around them.

### 3.2.2. Single choice principle:

```
    public class BankTerminalFactory
    {
        public static IBankTerminal CreateBankTerminal(BankTerminalModel model)
        {
            switch (model)
            {
                case BankTerminalModel.Brp:
                    return new BrpTerminal();
                case BankTerminalModel.Dcp:
                    return new DcpTerminal();
                default:
                    throw new ArgumentException("Unknown model");
            }
        }
    }
```

- We can't achieve a super-supple design which allows to introduce any possible features.

### 3.2.3. Development methodologies

- Waterfall
  - Try to foresee all the possible details.
- Agile
  - Iterative development process with high involvement of a customer.

### 3.2.4. Others related patterns

- Template Method
  - It defines the skeleton of an algorithm in an operation, deferring some steps to subclasses.
  - Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
- Strategy
  - Strategy enables an algorithm's behavior to be selected at runtime. The strategy pattern:
    - Defines a family of algorithms.
    - Encapsulates each algorithm.
    - Makes the algorithms interchangeable within that family.
- **Specification pattern**

### 3.2.5. Interfaces

- Interfaces can't be easily changed without breaking existing clients.
- Interfaces are easily extendable by clients.
- In other words...
  - An interface is suppler from the client's perspective: any class can implement as many interfaces as it wants to.
  - An interface is more rigid from the developer's perspective: it can't be easily changed and it does not support any kind of reusability.

### 3.2.6. Abstract Classes

- Supports reusability.
- Supports encapsulation.
- Can be extended easily without breaking existing clients.
- In other words...
  - An abstract class is supple from the developer's perspective.
  - An abstract class is rigid from the client's perspective.

### 3.2.7. Interfaces VS Abstract Classes

- Use abstract classes for building internal APIs.
- Use interfaces for providing external points of extension.
- In other words...
  - An abstract class is supple from the developer's perspective.
  - An abstract class is rigid from the client's perspective.

### 3.2.8. Common Smells

- Many conditional branches with if\else or switch\case statements.

### 3.2.9. Adhering to OCP

- Parameterization with delegates. "Chain of Responsibility" design pattern.
- Classic Inheritance or "Visitor" design pattern.
- Composition VS Inheritance. "Strategy" design pattern.

### 3.2.10. Resume

- Design should be open for extensions and closed for modification.
- Isolate a responsibility for creating objects in a single module (Single Choice Principle).
- Related patterns: "Template Method" and "Strategy".
- Interface is suppler from the client's perspective.
- Abstract class is suppler from the developer's perspective.
- To overcome the problem of predicting the future, we rely on "agile design".

## 3.3. L - Liskov substitution principle

- If **S** is a subtype of **T**, then objects of type **T** may be replaced with objects of type **S**, without breaking the program.
- The Liskov Substitution Principle states that Subtypes must be substitutable for their base types.
- And the third one is the Liskov substitution principle, we should able to use subclasses instead of the upper classes from which they derive without needing to make any changes in our code.
- So that means we can use **interfaces** which are changing to any implementation code.
- These interfaces can be manage with the substitution each other.

### 3.3.1. Ways of breaking substitutability

- Violating a Contract.
- Violating Covariance\Contravariance.

### 3.3.2. Contracts

- Programming to Contracts was elaborated by Bertrand Meyer [DbC](https://en.wikipedia.org/wiki/Design_by_contract).
  - "Object-Oriented Software Construction" by Meyer is recommended.
  - Eiffel [Eiffel](<https://en.wikipedia.org/wiki/Eiffel_(programming_language)>).

#### 3.3.2.1. What is contract?

- Contracts have some semantic payload.
- Interfaces have no any semantic payload.
- **Interfaces are not Contracts.**

#### 3.3.2.2. What constitutes a method's contract?

- Acceptable and unacceptable input values or types, and their meanings.
- Return values or types, and their meanings.
- Error and exception condition values or types that can occur, and their meanings.
- Side effects.
- Preconditions.
- Postconditions.
- Invariants.

### 3.3.3. Code contracts in C#

- You can write contracts in C# with a library called "Code Contracts". Harness the power of static code verification on correctness [CodeContracts](https://docs.microsoft.com/en-us/dotnet/framework/debug-trace-profile/code-contracts).
- "Code Contracts" library is not very popular.

### 3.3.4. The problem of representatives

- OOP can't directly map the relationships between objects in the real world into the same model of relationships between them in code.
- Child classes implement IS-A relationship with base classes - naive statement of OOP.
- Inheritors can require less and guarantee more but not vice-versa.
- Refused Bequest.
- Programming code just represents the concepts of square and rectangle.

### 3.3.5. Common Smells

- Method throws NotSupportedException.
- Empty or degenerative implementation.
- Downcasts.

### 3.3.6. Tips

- Tell, Don't Ask principle.
- LSP if often the result of OCP or ISP violations.
- If two classes share some logic and they are not substitutable.
  - Create new base class.
  - Inherit those two classes from a base class.
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

- Client's code references a class but uses only a small portion of its API:
  - Fat interface => Segregate it
  - Fat interface which is not under your control => Facade pattern

### 3.4.5. Related patterns

- Adapter pattern.
- Facade.

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

- DIP is about decoupling!
- Coupling indicates how dependent modules are on the inner workings of each other.
- DIP is applicable both at the source code and binary level.
- Low coupling:
  - Is often a sign of a well-structured computer system and a good design, and when combined with high cohesion, supports the general goals of high readability and maintainability.
- Definition:
  - High-level modules should not depend on low-level modules. Both should depend on abstractions.
  - Abstractions should not depend on details. Details should depend on abstactions.

### 3.5.1. Types of Dependencies

- Framework.
- 3rd party libs.
- External Systems like File System, Database, any system resource.
- Dependency on a custom type built on top of the .NET framework.

### 3.5.2. Policy depends on Details

- High-level objects of the domain layer directly depend on low-level objects of the infrastructural layer.
- It's hard to replace coupled dependencies.
- We can solve any problem by introducing an extra level of indirection.

![ClassDependOnDetails](/Images/ClassDependOnDetails.png)

### 3.5.3. Policy doesn't depend on Details

- IPersonRepository is a seam which inverts the dependencies.

![ClassDontDependOnDetails](/Images/ClassDontDependOnDetails.png)

### 3.5.4. Volatile and Stable Dependencies

- Dependencies can be divided into two camps:
  - Volatile.
  - Stable.

#### 3.5.4.1. Volatile Dependencies

- A dependency is volatile if any of the following criteria is true:
  - Dependency itself depends on the environment (web servers, db).
  - Dependency doesn't yet exist and is still under development.
  - Dependency which is not installed on all machines of developers.
  - Dependency has a nondeterministic behavior (randomizers inside).
- **If none of these true, a dependency is stable**.
- Volatile dependencies are those which we want to abstract away by introducing levels of indirection.

### 3.5.5. Definitions of IoC and DI

#### 3.5.5.1. Inversion of Control (IoC)

- IoC reflects the model of relationships between a caller and a callee.
- Classic flow of control implies that a client has a full control over the environment and sequence of calls to library methods.
- IoC implies that a callee takes control over some calls between caller and callee. (callbacks is the simplest form).
- Frameworks rule the client's code.

#### 3.5.5.2. DIP

- DIP is a detailed version of IoC.
- Concretizes that "High-level modules should not depend on low level modules".
- Dependency injection (DI) is a set of software design principles and patterns that enable us to develop loosely coupled code.

### 3.5.6. IoC and DI

- IoC can exist without DI.
- The main way to perform the inversion of control is to apply DI techniques.

### 3.5.7. DI Techniques

#### 3.5.7.1. Constructor Injection

- Protects the invariants.

##### 3.5.7.1.1. Possible pitfall

- Tends to accumulate many dependencies.
  - Smell of SRP violation, consider extracting a class.
- Several dependencies tend to be passed in together:

  ```
    interface IDependency1 { }
    interface IDependency2 { }
    interface IDependency3 { }
    interface IDependency4 { }

    class ViewModel
    {
      public ViewModel( IDependency1 d1,
                        IDependency2 d2,
                        IDependency3 d3,
                        IDependency4 d4)
      {

      }
    }
  ```

  ```
    class Infrastructure : IInfrastructure
    {
      public Infrastructure(IDependency1 d1,
                            IDependency2 d2,
                            IDependency3 d3,
                            IDependency4 d4)
      {

      }
    }

    class ViewModel
    {
      public ViewModel(IInfrastructure infrastructure)
      {

      }
    }
  ```

- Non-obligatory dependencies:

  ```
    public class Customer {
      private ILogger _logger = new Logger();

      public Customer() {}

      public Customer(ILogger logger) {
          _logger = logger;
      }
    }
  ```

- 3rd party framework imposes a public default constructor:

  ```
    public class Customer {
      private ICustomerRepo _repo;

      //HAVE TO EXPOSE
      public Customer() {}

      public Customer(ICustomerRepo repo) {
        _repo = repo;
      }
    }
  ```

- A certain dependency is used only in a single method.
  - Use method injection instead.

#### 3.5.7.2. Property Injection

##### 3.5.7.2.1. Possible pitfall

- Breaks encapsulation:

```
  public class Customer
  {
    public Customer()
    {
    }

    public ILogger Logger { get; set; } = new Logger();
  }
```

#### 3.5.7.3. Method Injection

- Apply if only one method uses a dependency or that dependency changes from one call to another.

```
  public interface ICurrencyRateProvider {
    int GetCurrencyRate(string currency);
  }

  public class PaymentService {
    public static Money CalculatePayment(ICurrencyRateProvider currencyRate) {
      return new Money();
    }
  }
```

##### 3.5.7.3.1. Pitfalls

- SRP Violation.
- IoC-Containers don't inject dependencies into methods.

### 3.5.8. Architectural Implications

#### 3.5.8.1. Application Boundaries

- Plugins can be deployed and developed independently.
- Divide the system by boundaries and invert the dependencies that cross those boundaries.
- Plugins define the boundaries of a system.

#### 3.5.8.2. Data-Centric Model

- Data and Schema rule the world.
- Logic in SQL Stored Procedures.
- SQL is suited for tuples processing, not for modeling objects relationships.

![DataCentricModel](Images/DataCentricModel.png)

#### 3.5.8.3. Domain-Centric Model

- Domain is the Core.
- Domain is Stable.

![DomainCentricModel](Images/DomainCentricModel.png)

#### 3.5.8.4. Enlarged Domain-Centric Model

- Ports and Adapters architecture.
- **Ports are seams** we introduce by extracting interfaces and **adapters are plugins** which come from the boundary of a system.
- Strive to keep the graph as flatter as you can.
- Who is responsible for keeping the control over the dependencies instantiation and their lifetime?
  - Answer: "Main as the infrastructural point."
  - Conforms to "Single Choice" principle.
  - Only Main knows about dependencies and their relationships.

#### 3.5.8.5. Pure DI and IoC-Containers

- Two ways of dealing with DI:
  - Manually create all the dependencies injecting them explicitly – "Pure DI".
  - Use an IoC-Container (also knows as DI-Containers).

##### 3.5.8.5.1. IoC-Containers

- IoC-Container is a framework which helps to apply DI.
  - Injects dependencies automatically.
  - Dependencies configuration.
  - Knows everything about dependencies.

#### 3.5.8.6. Common Smells

- A class explicitly creates one or more dependencies hiding them from a client.
- A class uses nondeterministic dependencies like DateTime or Random.
  - Extract a class which works with non-deterministic dependencies and cover it by integration tests.
  - Create an adapter.
- A class uses static dependencies, very often singletons.
- To remove the smell:
  - Extract a layer of indirection and make high-level policies independent of low-level details.
  - Adhere to the SRP.

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
  		d.SendCommand(9);
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

## 4.2. KISS - Keep it Simple, Stupid

- "Make everything as simple as possible, but not simpler" – _Albert Einstein_
- Simplicity is a key goal in design.
  - YAGNI is about removing unnecessary code.
  - KISS is about making the simplest implementation.
- KISS definition, "A simple solution is better than a complex one, even if the solution look stupid".

### 4.2.1. What is Simplicity?

- Simplicity is the state or equality of being simple.
- Something which is easy to understand or explain can be considered simple, in contrast to something complicated.
- The feeling of simplicity is relative.

### 4.2.2. Accidental & Essential Complexity

- Complexity imposed by the domain itself is called the "essential complexity".
- "Accidental complexity" is the complexity of our solutions which are intended to solve the problems of the domain.

### 4.2.3. Achieving Simplicity

- Main technique is **Decomposition**.
  - Decomposition underlies all the SOLID principles.
- SOLID are aimed at achieving simplest solutions;
  - Abusing SOLID leads to unnecessary complexity! => Unity and Struggle of Opposites law.
- Prefer composition over inheritance where possible.
- Stick with if-else and switch-case statements until you see that you need to introduce **polymorphism**.
- Avoid preemptive optimizations:
  - In 90% of cases slower solutions work enough fast..
  - The exceptions: app main aspect of which is the performance.
- Smaller classes and smaller methods are better:
  - The best method is a one-liner "Extract till you drop" technique.
- Don't rush to extract utility classes for private methods which are used from a single place within a class, leave it as it is until the other parts of code will require that method as well.
- Don't write parameterized general methods, prefer methods which solve a specific problem.
- Divide and conquer.
- Strive to avoid comments.
- Write prototypes and don't be afraid to throw them away.
- Keep the number of entities which solve a problem roughly from 5 to 7.
- **Constantly work on simplifying your code base**.
- Keep the amount of optimized code closer to 5-10%.

### 4.2.4. Simplicity

- Two values of software:
  - Correctness.
  - Good design.