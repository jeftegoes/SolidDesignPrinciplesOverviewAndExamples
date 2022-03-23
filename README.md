# Design Principles - SOLID

- SOLID software principles, is the set of principles put forward by **Robert C. Martin**, which ensures that the software developed is flexible, reusable, sustainable and understandable, prevents code repetition.
- So the main purpose of these principles, in order to easily adapted to requirements in the future and easier to add new features without the need to change anything in your code and also minimal change in code despite the new requirements and minimize the loss of time caused by the problems, such as the continuous correction on the code or even re-writing to code.

- So we have five principles.

## S - Single responsibility principle

- This will be you can't think about that, a **class** can only be changed for the sake of the purpose, it is the responsibility that is imposed on that class.
- So that class has only one job to do.
- We can talk about all the class and this class, only responsible one job and do not do anything else inside of that class or into the methods.

## O - Open/closed principle

- Again, a **class** or **function** should preserve existing properties and not allow changes.
- So that means it should not change its behavior and it should be able to gain new features.
- So that means open for the extensibility close for the modifications.

## L - Liskov substitution principle

- And the third one is the Liskov substitution principle, we should able to use subclasses instead of the upper classes from which they derive without needing to make any changes in our code.
- So that means we can use interfaces which are changing to any implementation code.
- These interfaces can be manage with the substitution each other.

## I - Interface segregation principle

- And the third one is the interface segregation principle.
- Instead of to collecting all responsible turns into a single interface, we should create more customized interfaces.
- We can separate the interfaces as per the responsibilities.
- It will be manage
- Easier to manage your interfaces and the dependencies.
- And the last one is a dependency.

## D - Dependency inversion principle

- Dependencies between classes should be as low as possible, and especially upper classes should not be dependent on the lower classes.
- But these are the main principles and all these principles is very similar to each other.
- We have some connection with these principles, but we can see that how we can apply these principles one by one when we are developing Ordering microservices.
