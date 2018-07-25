# Implementation of the Chain Of Responsability And Builder Patterns

This is an implementation of two design patterns: Chain Of Responsibility and Builder.

## Chain Of Responsability 

**The motivation:**

This pattern aims on the problem we face at software design when we have several requests and needs to be handling by different object depending on the type of information requested, that turn in plenty of references and instances on the program to make things possible.

Imagine a candy’s coin machine, it doesn’t matter what kind of coin you insert inside the slot because it has a chamber or chain of responsibility that check the coins and handle the task must be done by two options, return the coin or the candy, that the same the chain of responsibility do, it handles the request from the client and keep passing through the chain until an object inside could handle it.

In order to explain the element on this diagram we have:

**Customer:** this is the class that uses the chain of responsibility.

**ChainHandler:** Is an abstract class that the chain of responsibility nodes must implement to get the chain workable and become part of it.

**FinanceChainHandler:** Is a concreate implementation of the ChainHandler that handle the Finance request inside the chain.

**OperationChainHandler:** Is a concreate implementation of the ChainHandler that handle the Operation request inside the chain.

## Builder

**The motivation:**

This pattern aims on the problem we face at software design when we have a complex object and leave the responsibility to a builder instead of expose relevant information of instantiation that could turn on a security risk for the whole system.

Imagine you have an API and have a SDK that pass some relevant information you don’t want the client handle by his own, for make that possible you’d proceed on creating the object by other object that will handle all those critical aspect for the client thus sending the client the object he needs. Are like a credit card transaction where the payment is the product to be built and the credit card’s network is the black box where the payment is done letting you free about details like: API, network speed, connection point, etc and giving you what you need which is the payment.

In order to explain the element on this diagram we have:

**BuilderConstructor:** this is the class handles the objects creation based on the subclass passed to it.

**Builder:** Is an abstract class having the responsibility of a base class for all builders.

**ConcreateBuilder:** Is a concreate implementation of the Builder that creates an object of type Item.

**Item:** is the object we want to create.
