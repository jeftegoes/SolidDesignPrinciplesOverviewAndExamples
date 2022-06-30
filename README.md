# Solid overview <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. Intro](#1-intro)
  - [1.1. Building software](#11-building-software)
  - [1.2. Design smells](#12-design-smells)
  - [1.3. Design principles - SOLID](#13-design-principles---solid)
  - [1.4. How SOLID improve OO-programming skills​](#14-how-solid-improve-oo-programming-skills)
  - [1.5. Why we need SOLID?​](#15-why-we-need-solid)
- [2. What is SOLID?​](#2-what-is-solid)
  - [2.1. SRP - Single responsibility principle](#21-srp---single-responsibility-principle)
  - [2.2. O - Open/closed principle](#22-o---openclosed-principle)
  - [2.3. L - Liskov substitution principle](#23-l---liskov-substitution-principle)
  - [2.4. I - Interface segregation principle](#24-i---interface-segregation-principle)
  - [2.5. D - Dependency inversion principle](#25-d---dependency-inversion-principle)

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
- So the main purpose of these principles, in order to easily adapted to requirements in the future and easier to add new features without the need to change anything in your code and also minimal change in code despite the new requirements and minimize the loss of time caused by the problems, such as the continuous correction on the code or even re-writing to code.
- Not bound to any technology​
- SOLID is not a goal​
- "SOLIDness" is not measurable

## 1.4. How SOLID improve OO-programming skills​

- Meta principles on which all the other ​development principles are based​.
- Symptoms of code defects​.
- Foundations of SOLID principles​.
- Detect the violations of SOLID principles and how to fix the problems​.
- How meta and SOLID principles are related to each other ​and how to find the balance between them.

## 1.5. Why we need SOLID?​

- Poor design is a regular case​.
- Powerful programming language doesn't guarantee good design​.
- Designing skills are prerequisite for serious programming.

# 2. What is SOLID?​

- SOLID stands for SRP, OCP, LSP, and DIP.:
  - Single Responsibility Principle​.
  - Open/Closed Principle​.
  - Liskov Substitution Principle​.
  - Interface Segregation Principle.​
  - Dependency Inversion Principle.

## 2.1. SRP - Single responsibility principle

- This will be you can't think about that, a **class** can only be changed for the sake of the purpose, it is the responsibility that is imposed on that class.
- So that class has only one job to do.
- We can talk about all the class and this class, only responsible one job and do not do anything else inside of that class or into the methods.

## 2.2. O - Open/closed principle

- Again, a **class** or **function** should preserve existing properties and not allow changes.
- So that means it should not change its behavior and it should be able to gain new features.
- So that means open for the extensibility close for the modifications.

## 2.3. L - Liskov substitution principle

- And the third one is the Liskov substitution principle, we should able to use subclasses instead of the upper classes from which they derive without needing to make any changes in our code.
- So that means we can use interfaces which are changing to any implementation code.
- These interfaces can be manage with the substitution each other.

## 2.4. I - Interface segregation principle

- And the third one is the interface segregation principle.
- Instead of to collecting all responsible turns into a single interface, we should create more customized interfaces.
- We can separate the interfaces as per the responsibilities.
- It will be manage
- Easier to manage your interfaces and the dependencies.
- And the last one is a dependency.

## 2.5. D - Dependency inversion principle

- Dependencies between classes should be as low as possible, and especially upper classes should not be dependent on the lower classes.
- But these are the main principles and all these principles is very similar to each other.
- We have some connection with these principles, but we can see that how we can apply these principles one by one when we are developing Ordering microservices.
