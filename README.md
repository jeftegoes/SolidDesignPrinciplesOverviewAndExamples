# Solid overview <!-- omit in toc -->

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
  - [2.4. O - Open/closed principle](#24-o---openclosed-principle)
  - [2.5. L - Liskov substitution principle](#25-l---liskov-substitution-principle)
  - [2.6. I - Interface segregation principle](#26-i---interface-segregation-principle)
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
- Applying SRP we want to separate different concerns. ​A class should do one thing, ​and do it well!
- SRP can be applied at different levels:​
  - function​
  - object​
  - module
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

## 2.4. O - Open/closed principle

- Again, a **class** or **function** should preserve existing properties and not allow changes.
- So that means it should not change its behavior and it should be able to gain new features.
- So that means open for the extensibility close for the modifications.

## 2.5. L - Liskov substitution principle

- And the third one is the Liskov substitution principle, we should able to use subclasses instead of the upper classes from which they derive without needing to make any changes in our code.
- So that means we can use interfaces which are changing to any implementation code.
- These interfaces can be manage with the substitution each other.

## 2.6. I - Interface segregation principle

- And the third one is the interface segregation principle.
- Instead of to collecting all responsible turns into a single interface, we should create more customized interfaces.
- We can separate the interfaces as per the responsibilities.
- It will be manage
- Easier to manage your interfaces and the dependencies.
- And the last one is a dependency.

## 2.7. D - Dependency inversion principle

- Dependencies between classes should be as low as possible, and especially upper classes should not be dependent on the lower classes.
- But these are the main principles and all these principles is very similar to each other.
- We have some connection with these principles, but we can see that how we can apply these principles one by one when we are developing Ordering microservices.
